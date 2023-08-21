using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King.AbpVnextPro.Cli.Commands;

public class HelpCommand : IConsoleCommand, ITransientDependency
{
    public const string Name = "help";

    public ILogger<HelpCommand> Logger { get; set; }
    protected AbpCliOptions AbpCliOptions { get; }
    protected IServiceScopeFactory ServiceScopeFactory { get; }

    public HelpCommand(IOptions<AbpCliOptions> cliOptions,
        IServiceScopeFactory serviceScopeFactory)
    {
        ServiceScopeFactory = serviceScopeFactory;
        Logger = NullLogger<HelpCommand>.Instance;
        AbpCliOptions = cliOptions.Value;
    }

    public Task ExecuteAsync(CommandLineArgs commandLineArgs)
    {
        Logger.LogInformation(GetUsageInfo());
        return Task.CompletedTask;
    }

    public string GetUsageInfo()
    {
        var sb = new StringBuilder();

        sb.AppendLine("查看命令帮助:");
        sb.AppendLine("    king.abp help");
        sb.AppendLine("命令列表:");

        foreach (var command in AbpCliOptions.Commands.ToArray())
        {
            string shortDescription;

            using (var scope = ServiceScopeFactory.CreateScope())
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
        return "king.abp help";
    }
}
