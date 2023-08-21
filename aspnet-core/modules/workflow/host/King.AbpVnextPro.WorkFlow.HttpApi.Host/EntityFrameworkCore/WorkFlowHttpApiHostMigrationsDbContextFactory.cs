using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace King.AbpVnextPro.WorkFlow.EntityFrameworkCore;

public class WorkFlowHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<WorkFlowHttpApiHostMigrationsDbContext>
{
    public WorkFlowHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<WorkFlowHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("WorkFlow"));

        return new WorkFlowHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
