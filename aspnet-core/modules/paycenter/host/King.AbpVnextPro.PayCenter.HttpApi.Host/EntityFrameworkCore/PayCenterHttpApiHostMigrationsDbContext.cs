using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.PayCenter.EntityFrameworkCore;

public class PayCenterHttpApiHostMigrationsDbContext : AbpDbContext<PayCenterHttpApiHostMigrationsDbContext>
{
    public PayCenterHttpApiHostMigrationsDbContext(DbContextOptions<PayCenterHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigurePayCenter();
    }
}
