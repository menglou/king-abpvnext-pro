using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace King.AbpVnextPro.Openiddict.EntityFrameworkCore;

public class OpeniddictHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<OpeniddictHttpApiHostMigrationsDbContext>
{
    public OpeniddictHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<OpeniddictHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Openiddict"));

        return new OpeniddictHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
