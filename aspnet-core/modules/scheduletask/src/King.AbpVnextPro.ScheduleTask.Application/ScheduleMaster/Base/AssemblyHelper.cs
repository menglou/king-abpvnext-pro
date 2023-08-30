using Microsoft.AspNetCore.Mvc.ApplicationParts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.ScheduleTask.ScheduleMaster.Base
{
    public class AssemblyHelper
    {
        /// <summary>
        /// 获取程序集的完整路径
        /// </summary>
        /// <param name="sid"></param>
        /// <param name="assemblyName"></param>
        /// <returns></returns>
        public static string GetTaskAssemblyPath(Guid sid, string assemblyName)
        {
            string path = $"\\www\\root\\{sid}\\{assemblyName}.dll";
            return $"{Directory.GetCurrentDirectory()}{path}".Replace('\\', Path.DirectorySeparatorChar);
        }
        /// <summary>
        /// 创建程序集实例
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sid"></param>
        /// <param name="assemblyName"></param>
        /// <param name="className"></param>
        /// <param name="alcWeakRef"></param>
        /// <returns></returns>
        public static TaskInstance CreateTaskInstance(ScheduleTaskAssemblyContext context, Guid sid, string assemblyName, string className, out WeakReference alcWeakRef)
        {
            try
            {
                string assemblyPath = GetTaskAssemblyPath(sid, assemblyName);
                //加载 assemblyPath 程序集到 MyAssemblyContext 上下文中
                Assembly clib = context.LoadFromAssemblyName(new AssemblyName(Path.GetFileNameWithoutExtension(assemblyPath)));

                //引用 程序集加载上下文，用于确认当UnLoad时，上下文被正确清理掉了。
                alcWeakRef = new WeakReference(context, trackResurrection: true);

                Type t = clib.GetType(className,true,true);

                object obj = Activator.CreateInstance(t);

                TaskInstance taskInstance = new TaskInstance()
                {
                    Type = t,
                    Instance = obj,
                };
                return taskInstance;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 加载应用程序域
        /// </summary>
        /// <param name="assemblyName"></param>
        /// <returns></returns>
        public static ScheduleTaskAssemblyContext LoadAssemblyContext(Guid sid, string assemblyName)
        {
            string assemblyPath = GetTaskAssemblyPath(sid, assemblyName);
            ScheduleTaskAssemblyContext loadContext = new ScheduleTaskAssemblyContext(assemblyPath);
            return loadContext;
        }

        /// <summary>
        /// 卸载应用程序域
        /// </summary>
        /// <param name="context"></param>
        /// <param name="alcWeakRef"></param>
        public static void UnLoadAssemblyLoadContext(ScheduleTaskAssemblyContext context,  WeakReference alcWeakRef)
        {
            if (context != null)
            {
                context.Unload();
                //显示调用GC清理程序集加载上下文。
                for (int i = 0; alcWeakRef.IsAlive && (i < 10); i++)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
        }
    }
}
