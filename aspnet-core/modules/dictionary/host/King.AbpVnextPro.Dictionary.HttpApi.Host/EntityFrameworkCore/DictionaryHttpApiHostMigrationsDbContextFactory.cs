using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace King.AbpVnextPro.Dictionary.EntityFrameworkCore;

public class DictionaryHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<DictionaryHttpApiHostMigrationsDbContext>
{
    public DictionaryHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<DictionaryHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Dictionary"));

        return new DictionaryHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
