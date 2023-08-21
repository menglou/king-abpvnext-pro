using King.AbpVnextPro.Dictionary.DataDictionarys;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.Dictionary.EntityFrameworkCore;

[ConnectionStringName(DictionaryDbProperties.ConnectionStringName)]
public class DictionaryDbContext : AbpDbContext<DictionaryDbContext>, IDictionaryDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public DictionaryDbContext(DbContextOptions<DictionaryDbContext> options)
        : base(options)
    {

    }

    public DbSet<DataDictionary> DataDictionarys { get; set; }

    public DbSet<DataDictionaryDetail> DataDictionaryDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureDictionary();
    }
}
