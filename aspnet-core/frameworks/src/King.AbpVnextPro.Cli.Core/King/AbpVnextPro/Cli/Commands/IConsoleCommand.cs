namespace King.AbpVnextPro.Cli.Commands;
public interface IConsoleCommand
{
    Task ExecuteAsync(CommandLineArgs commandLineArgs);

    string GetUsageInfo();

    string GetShortDescription();
}