using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using King.AbpVnextPro.File.Files;

namespace King.AbpVnextPro.File.EntityFrameworkCore;

[ConnectionStringName(FileDbProperties.ConnectionStringName)]
public interface IFileDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */

    DbSet<King.AbpVnextPro.File.Files.File> Files { get; }
}
