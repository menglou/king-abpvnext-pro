﻿
using King.AbpVnextPro.Cli.Options;

namespace King.AbpVnextPro.Cli.SourceCode;
public class SourceCodeManager : ITransientDependency, ISourceCodeManager
{
    private readonly ILogger<SourceCodeManager> _logger;
    private readonly IAbpVnextProManager _abpVnextProManager;
    private readonly AbpVnextProCliOptions _cliOptions;

    public SourceCodeManager(ILogger<SourceCodeManager> logger, IOptions<Options.AbpVnextProCliOptions> options, IAbpVnextProManager abpProManager)
    {
        _logger = logger;
        _abpVnextProManager = abpProManager;
        _cliOptions = options.Value;
    }

    /// <summary>
    /// 获取源码
    /// </summary>
    /// <param name="version">版本</param>
    public async Task<TemplateFile> GetAsync(string version)
    {
        var latestVersion = await _abpVnextProManager.GetLatestSourceCodeVersionAsync();
        if (version == null)
        {
            version = latestVersion ?? throw new Exception("请检查版本是否正确");
        }
        else
        {
            if (!await _abpVnextProManager.CheckSourceCodeVersionAsync(version))
            {
                throw new Exception("没有找到指定的版本: " + version);
            }
        }

        var localCacheFile = Path.Combine(CliPaths.TemplateCache, _cliOptions.RepositoryId + "-" + version + ".zip");

        DirectoryHelper.DeleteIfExists(Path.Combine(CliPaths.TemplateCache, _cliOptions.RepositoryId + "-" + version), true);

        _logger.LogInformation($"King AbpVnextPro Version:{version}");
        _logger.LogInformation($"模板生成中......");

        if (!File.Exists(localCacheFile))
        {
            return new TemplateFile(version, localCacheFile, await _abpVnextProManager.DownloadAsync(version, localCacheFile));
        }
        else
        {
            File.Delete(localCacheFile);
            return new TemplateFile(version, localCacheFile, await _abpVnextProManager.DownloadAsync(version, localCacheFile));
        }
    }


    public void ExtractProjectZip(SourceCodeContext context)
    {
        using (var templateFileStream = new MemoryStream(context.TemplateFile.FileBytes))
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

                    var fullZipToPath = Path.Combine(CliPaths.TemplateCache, zipEntry.Name);
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
                    using (var streamWriter = File.Create(fullZipToPath))
                    {
                        StreamUtils.Copy(zipInputStream, streamWriter, buffer);
                    }

                    zipEntry = zipInputStream.GetNextEntry();
                }
            }
        }

        context.ExtractProjectPath = Path.Combine(CliPaths.TemplateCache, _cliOptions.RepositoryId + "-" + context.TemplateFile.Version);
    }

    public void MoveTemplate(SourceCodeContext context)
    {
        // var codePath= Path.Combine(context.OutputFolder, context.CompanyName + "." + context.ProjectName);
        //
        // DirectoryHelper.DeleteIfExists(codePath,true);
        //
        // if (context.IsSource)
        // {
        //     context.TemplateFolder = Path.Combine(context.OutputFolder, _options.RepositoryId + "-" + context.TemplateFile.Version);
        // }
        // else
        // {
        //     // 获取本地源码地址
        //     context.TemplateFolder = Path.Combine(context.OutputFolder, _options.RepositoryId + "-" + context.TemplateFile.Version, "templates", context.TemplateKey);
        // }
        //
        // Directory.Move(context.TemplateFolder, codePath);
        // context.OutputFolder = codePath;

        DirectoryAndFileHelper.CopyFolder(context.ExtractProjectPath, context.OutputFolder, "docs");
    }

    public void ReplaceTemplates(SourceCodeContext context)
    {
        try
        {
            ReplaceHelper.ReplaceTemplates(
                context.ExtractProjectPath,
                context.OldCompanyName,
                context.OldProjectName,
                context.OldModuleName,
                context.CompanyName,
                context.ProjectName,
                context.ModuleName,
                context.ReplaceSuffix,
                context.TemplateFile.Version);

            if (context.IsSource)
            {
                context.TemplateFolder = context.ExtractProjectPath;
            }
            else
            {
                // 获取本地源码地址
                context.TemplateFolder = Path.Combine(context.ExtractProjectPath, "templates", context.TemplateKey);
            }

            context.OutputFolder = Path.Combine(context.OutputFolder, context.CompanyName + "." + context.ProjectName);
            DirectoryHelper.DeleteIfExists(context.OutputFolder, true);
            DirectoryAndFileHelper.CopyFolder(context.TemplateFolder, context.OutputFolder, context.ExcludeFiles);

            _logger.LogInformation($"OutputFolder:{context.OutputFolder}");
        }
        finally
        {
            DirectoryHelper.DeleteIfExists(context.ExtractProjectPath, true);
        }
    }
}