using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.Openiddict.EntityFrameworkCore;

[ConnectionStringName(OpeniddictDbProperties.ConnectionStringName)]
public interface IOpeniddictDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
