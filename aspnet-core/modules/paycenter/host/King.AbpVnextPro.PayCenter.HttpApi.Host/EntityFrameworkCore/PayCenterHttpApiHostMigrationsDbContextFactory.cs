using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace King.AbpVnextPro.PayCenter.EntityFrameworkCore;

public class PayCenterHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<PayCenterHttpApiHostMigrationsDbContext>
{
    public PayCenterHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<PayCenterHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("PayCenter"));

        return new PayCenterHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
