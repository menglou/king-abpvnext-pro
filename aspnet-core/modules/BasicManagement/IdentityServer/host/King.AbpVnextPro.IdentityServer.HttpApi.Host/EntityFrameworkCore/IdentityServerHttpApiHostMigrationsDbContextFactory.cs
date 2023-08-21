using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace King.AbpVnextPro.IdentityServer.EntityFrameworkCore;

public class IdentityServerHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<IdentityServerHttpApiHostMigrationsDbContext>
{
    public IdentityServerHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<IdentityServerHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("IdentityServer"));

        return new IdentityServerHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
