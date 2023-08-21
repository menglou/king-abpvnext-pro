namespace King.AbpVnextPro.WebGateway;
 public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<AbpVnextProWebGatewayModule>();
    }

    public void Configure(IApplicationBuilder app)
    {
        app.InitializeApplication();
    }
}