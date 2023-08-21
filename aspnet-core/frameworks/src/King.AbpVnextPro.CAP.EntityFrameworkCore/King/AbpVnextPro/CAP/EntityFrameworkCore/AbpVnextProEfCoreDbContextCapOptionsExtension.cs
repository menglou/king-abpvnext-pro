

namespace King.AbpVnextPro.CAP.EntityFrameworkCore;

public class AbpVnextProEfCoreDbContextCapOptionsExtension : ICapOptionsExtension
{
    public string CapUsingDbConnectionString { get; init; }
    
    public void AddServices(IServiceCollection services)
    {
        services.Configure<AbpVnextProEfCoreDbContextCapOptions>(options =>
        {
            options.CapUsingDbConnectionString = CapUsingDbConnectionString;
        });
    }
}