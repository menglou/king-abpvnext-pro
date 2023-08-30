using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using JetBrains.Annotations;
using King.AbpVnextPro.File;
using King.AbpVnextPro.File.Filess;
using King.AbpVnextPro.ScheduleTask.ScheduleMaster.Base;
using King.AbpVnextPro.ScheduleTask.Schedules;
using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace King.AbpVnextPro.ScheduleTask.ScheduleMaster.Job
{
    public class AssemblyJob : IJob
    {
        private ScheduleTaskAssemblyContext loadContext;
        public TaskInstance RunnableInstance;
        private ILogger<HttpJob> _logger { get; set; }
        private IFilesAppService _filesAppService;
        public AssemblyJob(ILogger<HttpJob> logger, IFilesAppService filesAppService)
        {
            _logger = logger;
            _filesAppService = filesAppService;
        }
        public async Task Execute(IJobExecutionContext context)
        {
            await Run(context);
        }

        private async Task Run(IJobExecutionContext context)
        {
            IJobDetail job = context.JobDetail;
            var jobparam = job.JobDataMap["JobParam"] as ScheduleManagerDto;
            _logger.LogInformation("---------创建程序集实例实例-----------");
            CreateRunnableInstance(jobparam.Id, jobparam.FileName, jobparam.AssemblyName, jobparam.ClassName, jobparam.MethodName);
        }

        //创建程序集实例
        private async void CreateRunnableInstance(Guid sid, string filename, string assemblyName, string className,string methodName)
        {
            string dllpath = string.Empty;
            string basepath = "{Directory.GetCurrentDirectory()}\\wwwroot\\plugins";
            //程序集的路径
            string assemblyPath = $"{Directory.GetCurrentDirectory()}\\wwwroot\\plugins\\{sid}\\{filename}";
            //判断文件夹存不存在,不存在就创建
            if (!Directory.Exists(assemblyPath))
            {
                //根据id 获取存在在blob 中文件
                var fileDto = await _filesAppService.FindByBlobNameAsync(sid.ToString());
                //根据上传到blob 的文件解压zip 文件
                string didcpath= ExtractProjectZip(fileDto.Bytes, basepath, sid, filename);

                dllpath = $"{didcpath}\\{assemblyName}.dll";
            }
            else
            {
                dllpath = $"{basepath}\\{assemblyName}.dll";
            }
            //string path = $"\\wwwroot\\plugins\\{sid}\\{assemblyName}.dll";
            ////保存在本地文件中
            //string assemblyPath = $"{Directory.GetCurrentDirectory()}{path}".Replace('\\', Path.DirectorySeparatorChar);

            ////判断文件存不存在
            //if (!System.IO.File.Exists(assemblyPath))
            //{
            //    //根据id 获取存在在blob 中文件
            //    var fileDto = await _filesAppService.FindByBlobNameAsync(sid.ToString());

            //    using (FileStream stream = new FileStream(assemblyPath, FileMode.Create, FileAccess.Write))
            //    {
            //        stream.Write(fileDto.Bytes, 0, fileDto.Bytes.Length);
            //        stream.Close();
            //    }
            //}


            //加载程序集的文件地址
            string contextpath= dllpath.Replace('\\', Path.DirectorySeparatorChar);

            WeakReference weakReference; 
            loadContext = AssemblyHelper.LoadAssemblyContext(contextpath);
            RunnableInstance = AssemblyHelper.CreateTaskInstance(
                loadContext,
                contextpath,
                className,
                out weakReference
            );
            if (RunnableInstance == null)
            {
                throw new InvalidCastException($"任务实例创建失败。程序集：{assemblyName}，类型：{className}");
            }

            _logger.LogInformation("-----------开始调用程序集方法------------");
            //开启一个计时
            Stopwatch stopwatch = new Stopwatch();
            //调用方法
            RunnableInstance.Type.GetMethod(methodName).Invoke(RunnableInstance.Instance, new object[] { });

            //计时结束
            stopwatch.Stop();

            _logger.LogInformation($"-----------调用程序集方法结束,用时{stopwatch.ElapsedMilliseconds}------------");

            _logger.LogInformation("-----------开始卸载程序集------------");
            //卸载实例
            AssemblyHelper.UnLoadAssemblyLoadContext(loadContext, weakReference);

            _logger.LogInformation("-----------卸载程序集结束------------");
        }

        //解压程序集文件
        public string ExtractProjectZip(byte[]filebytes,string assemblyPath,Guid sid,string filename)
        {
            string ExtractProjectPath = string.Empty;
            using (var templateFileStream = new MemoryStream(filebytes))
            {
                using (var zipInputStream = new ZipInputStream(templateFileStream))
                {
                    var zipEntry = zipInputStream.GetNextEntry();
                    while (zipEntry != null)
                    {
                        if (string.IsNullOrWhiteSpace(zipEntry.Name))
                        {
                            zipEntry = zipInputStream.GetNextEntry();
                            continue;
                        }

                        var fullZipToPath = Path.Combine(assemblyPath, zipEntry.Name);
                        var directoryName = Path.GetDirectoryName(fullZipToPath);

                        if (!string.IsNullOrEmpty(directoryName))
                        {
                            Directory.CreateDirectory(directoryName);
                        }

                        var fileName = Path.GetFileName(fullZipToPath);
                        if (fileName.Length == 0)
                        {
                            zipEntry = zipInputStream.GetNextEntry();
                            continue;
                        }

                        var buffer = new byte[4096]; // 4K is optimum
                        using (var streamWriter =System.IO.File.Create(fullZipToPath))
                        {
                            StreamUtils.Copy(zipInputStream, streamWriter, buffer);
                        }

                        zipEntry = zipInputStream.GetNextEntry();
                    }
                }
            }

            ExtractProjectPath = Path.Combine(assemblyPath, sid.ToString(),filename);

            return ExtractProjectPath;
        }
    }
}
