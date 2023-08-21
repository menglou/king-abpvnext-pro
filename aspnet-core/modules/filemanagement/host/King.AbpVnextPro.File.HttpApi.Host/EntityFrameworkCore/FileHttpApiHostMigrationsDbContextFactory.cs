using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace King.AbpVnextPro.File.EntityFrameworkCore;

public class FileHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<FileHttpApiHostMigrationsDbContext>
{
    public FileHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<FileHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("File"));

        return new FileHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
