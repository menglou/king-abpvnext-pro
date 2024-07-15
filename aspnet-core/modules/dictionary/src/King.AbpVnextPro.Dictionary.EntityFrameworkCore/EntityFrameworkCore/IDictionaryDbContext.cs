using King.AbpVnextPro.Dictionary.DataDictionarys;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.Dictionary.EntityFrameworkCore;

[ConnectionStringName(DictionaryDbProperties.ConnectionStringName)]
public interface IDictionaryDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */

    DbSet<DataDictionary> DataDictionary { get; }

    DbSet<DataDictionaryDetail> DataDictionaryDetail { get; }
}
