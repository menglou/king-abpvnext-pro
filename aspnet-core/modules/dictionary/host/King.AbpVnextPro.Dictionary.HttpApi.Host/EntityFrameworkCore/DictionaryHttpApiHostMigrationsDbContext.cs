using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.Dictionary.EntityFrameworkCore;

public class DictionaryHttpApiHostMigrationsDbContext : AbpDbContext<DictionaryHttpApiHostMigrationsDbContext>
{
    public DictionaryHttpApiHostMigrationsDbContext(DbContextOptions<DictionaryHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureDictionary();
    }
}
