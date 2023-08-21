using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.IdentityServer.EntityFrameworkCore;

public class IdentityServerHttpApiHostMigrationsDbContext : AbpDbContext<IdentityServerHttpApiHostMigrationsDbContext>
{
    public IdentityServerHttpApiHostMigrationsDbContext(DbContextOptions<IdentityServerHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureIdentityServer();
    }
}
