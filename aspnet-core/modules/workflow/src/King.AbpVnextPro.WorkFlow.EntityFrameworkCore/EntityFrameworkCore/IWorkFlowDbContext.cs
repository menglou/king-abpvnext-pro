using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.WorkFlow.EntityFrameworkCore;

[ConnectionStringName(WorkFlowDbProperties.ConnectionStringName)]
public interface IWorkFlowDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
