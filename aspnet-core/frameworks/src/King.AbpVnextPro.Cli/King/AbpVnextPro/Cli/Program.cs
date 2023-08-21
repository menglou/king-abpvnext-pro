
namespace King.AbpVnextPro.Cli;

public class Program
{
    public static async Task Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .MinimumLevel.Override("Volo.Abp", LogEventLevel.Warning)
            .MinimumLevel.Override("System.Net.Http.HttpClient", LogEventLevel.Warning)
            .MinimumLevel.Override("Volo.Abp.IdentityModel", LogEventLevel.Information)
            .MinimumLevel.Override("Volo.Abp.Cli", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .WriteTo.File(Path.Combine(CliPaths.Log, "king.abp-pro-cli-logs.txt"))
            .WriteTo.Console()
            .CreateLogger();
        using var application = AbpApplicationFactory.Create<AbpVnextProCliModule>(
            options =>
            {
                options.UseAutofac();
                options.Services.AddLogging(c => c.AddSerilog());
            });
        application.Initialize();

        await application.ServiceProvider
            .GetRequiredService<CliService>()
            .RunAsync(args);

        application.Shutdown();

        Log.CloseAndFlush();
    }
}