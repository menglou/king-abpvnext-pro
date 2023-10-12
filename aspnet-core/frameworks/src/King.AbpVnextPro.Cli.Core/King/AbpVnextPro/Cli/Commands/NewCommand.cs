

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Text;

namespace King.AbpVnextPro.Cli.Commands;

public class NewCommand : IConsoleCommand, ITransientDependency
{
    public const string Name = "new";
    private readonly ILogger<NewCommand> _logger;
    private readonly AbpCliOptions _abpCliOptions;
    private readonly IServiceScopeFactory _serviceScopeFactory;
    private readonly Options.AbpVnextProCliOptions _cliOptions;
    private readonly ISourceCodeManager _sourceCodeManager;

    public NewCommand(
        IOptions<AbpCliOptions> abpCliOptions,
        ILogger<NewCommand> logger,
        IServiceScopeFactory serviceScopeFactory,
        IOptions<Options.AbpVnextProCliOptions> options,
        ISourceCodeManager sourceCodeManager)
    {
        _logger = logger;
        _serviceScopeFactory = serviceScopeFactory;
        _sourceCodeManager = sourceCodeManager;
        _cliOptions = options.Value;
        _abpCliOptions = abpCliOptions.Value;
    }

    public async Task ExecuteAsync(CommandLineArgs commandLineArgs)
    {
        #region 参数获取

        var context = new SourceCodeContext();
        // 检查模板是否正确
        var template = commandLineArgs.Options.GetOrNull(CommandOptions.Template.Short, CommandOptions.Template.Long);
        if (template.IsNullOrWhiteSpace())
        {
            _logger.LogError("请输入模板名称");
            GetUsageInfo();
            return;
        }

        var templateOptions = _cliOptions.Templates.FirstOrDefault(e => e.Name == template);
        if (templateOptions == null)
        {
            _logger.LogError("模板类型不正确");
            GetUsageInfo();
            return;
        }

        context.RepositoryId = _cliOptions.RepositoryId;
        context.Token = _cliOptions.DecryptToken;
        context.Owner = _cliOptions.Owner;
        context.GiteeOwner = _cliOptions.GiteeOwner;
        context.TemplateName = templateOptions.Name;
        context.TemplateKey = templateOptions.Key;
        context.IsSource = templateOptions.IsSource;
        context.ExcludeFiles = templateOptions.ExcludeFiles;
        context.ReplaceSuffix = templateOptions.ReplaceSuffix;
        context.OldCompanyName = templateOptions.OldCompanyName;
        context.OldProjectName = templateOptions.OldProjectName;
        context.OldModuleName = templateOptions.OldModuleName;
        // if (commandLineArgs.Target.IsNullOrWhiteSpace())
        // {
        //     GetUsageInfo();
        //     return;
        // }

        //校验是否输入鉴权方式名称
        context.CompanyName = commandLineArgs.Options.GetOrNull(CommandOptions.Company.Short, CommandOptions.Company.Long);
        if (context.CompanyName.IsNullOrWhiteSpace())
        {
            _logger.LogError("请输入公司名称");
            GetUsageInfo();
            return;
        }

        //校验是否输入项目名称
        context.ProjectName = commandLineArgs.Options.GetOrNull(CommandOptions.Project.Short, CommandOptions.Project.Long);
        if (context.ProjectName.IsNullOrWhiteSpace())
        {
            _logger.LogError("请输入项目名称");
            _logger.LogInformation(GetUsageInfo());
            return;
        }

        //校验是否输入模块名称
        context.ModuleName = commandLineArgs.Options.GetOrNull(CommandOptions.Module.Short, CommandOptions.Module.Long);
        if (context.TemplateKey == "king-abp-vnext-pro-nuget-module" && context.ModuleName.IsNullOrWhiteSpace())
        {
            _logger.LogError("请输入模块名称");
            _logger.LogInformation(GetUsageInfo());
            return;
        }

        var outputFolder = commandLineArgs.Options.GetOrNull(CommandOptions.OutputFolder.Short, CommandOptions.OutputFolder.Long);

        outputFolder = outputFolder != null ? Path.GetFullPath(outputFolder) : Directory.GetCurrentDirectory();

        context.OutputFolder = outputFolder;
        //版本
        var version = commandLineArgs.Options.GetOrNull(CommandOptions.Version.Short, CommandOptions.Version.Long);

        #endregion

        // 获取源码
        context.TemplateFile = await _sourceCodeManager.GetAsync(version);

        // 解压
        _sourceCodeManager.ExtractProjectZip(context);

        // 替换模板
        _sourceCodeManager.ReplaceTemplates(context);

        // 打开文件夹
        Process.Start("explorer.exe", context.OutputFolder);
    }

    public string GetUsageInfo()
    {
        var sb = new StringBuilder();

        sb.AppendLine("查看命令帮助:");
        sb.AppendLine("    king.abp help");
        sb.AppendLine("命令列表:");

        foreach (var command in _abpCliOptions.Commands.ToArray())
        {
            string shortDescription;

            using (var scope = _serviceScopeFactory.CreateScope())
            {
                shortDescription = ((IConsoleCommand)scope.ServiceProvider
                    .GetRequiredService(command.Value)).GetShortDescription();
            }

            sb.Append("    > ");
            sb.Append(command.Key);
            sb.Append(string.IsNullOrWhiteSpace(shortDescription) ? "" : ":");
            sb.Append(" ");
            sb.AppendLine(shortDescription);
        }

        return sb.ToString();
    }

    public string GetShortDescription()
    {
        var message = Environment.NewLine;
        message += $"           > king.abp new -t pro.id4.all -c 公司名称 -p 项目名称 -v 版本(默认LastRelease) -o 默认当前控制台执行目录";
        message += Environment.NewLine;
        message += $"           > king.abp new -t pro.openiddict.all -c 公司名称 -p 项目名称 -v 版本(默认LastRelease) -o 默认当前控制台执行目录";
        message += Environment.NewLine;
        message += $"           > king.abp new -t pro.id4.simplify -c 公司名称 -p 项目名称 -v 版本(默认LastRelease) -o 默认当前控制台执行目录";
        message += Environment.NewLine;
        message += $"           > king.abp new -t pro.openiddict.simplify -c 公司名称 -p 项目名称 -v 版本(默认LastRelease) -o 默认当前控制台执行目录";
        return message;
    }
}