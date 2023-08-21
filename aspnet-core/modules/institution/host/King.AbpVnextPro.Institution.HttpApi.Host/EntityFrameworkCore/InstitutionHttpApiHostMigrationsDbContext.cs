using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.Institution.EntityFrameworkCore;

public class InstitutionHttpApiHostMigrationsDbContext : AbpDbContext<InstitutionHttpApiHostMigrationsDbContext>
{
    public InstitutionHttpApiHostMigrationsDbContext(DbContextOptions<InstitutionHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureInstitution();
    }
}
