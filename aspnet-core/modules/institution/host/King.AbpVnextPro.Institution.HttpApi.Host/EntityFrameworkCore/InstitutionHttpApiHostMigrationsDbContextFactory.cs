using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace King.AbpVnextPro.Institution.EntityFrameworkCore;

public class InstitutionHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<InstitutionHttpApiHostMigrationsDbContext>
{
    public InstitutionHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<InstitutionHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Institution"));

        return new InstitutionHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
