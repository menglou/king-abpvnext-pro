using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace King.AbpVnextPro.Notice.EntityFrameworkCore;

public class NoticeHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<NoticeHttpApiHostMigrationsDbContext>
{
    public NoticeHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<NoticeHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Notice"));

        return new NoticeHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
