using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.Openiddict.EntityFrameworkCore;

public class OpeniddictHttpApiHostMigrationsDbContext : AbpDbContext<OpeniddictHttpApiHostMigrationsDbContext>
{
    public OpeniddictHttpApiHostMigrationsDbContext(DbContextOptions<OpeniddictHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureOpeniddict();
    }
}
