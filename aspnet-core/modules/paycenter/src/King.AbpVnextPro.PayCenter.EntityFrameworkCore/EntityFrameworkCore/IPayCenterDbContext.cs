using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.PayCenter.EntityFrameworkCore;

[ConnectionStringName(PayCenterDbProperties.ConnectionStringName)]
public interface IPayCenterDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
