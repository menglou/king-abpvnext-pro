using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace King.AbpVnextPro.ScheduleTask.EntityFrameworkCore;

public class ScheduleTaskHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ScheduleTaskHttpApiHostMigrationsDbContext>
{
    public ScheduleTaskHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ScheduleTaskHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("ScheduleTask"));

        return new ScheduleTaskHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
