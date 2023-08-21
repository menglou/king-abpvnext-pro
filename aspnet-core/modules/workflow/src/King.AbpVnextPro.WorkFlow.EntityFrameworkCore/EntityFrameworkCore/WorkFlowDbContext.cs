using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.WorkFlow.EntityFrameworkCore;

[ConnectionStringName(WorkFlowDbProperties.ConnectionStringName)]
public class WorkFlowDbContext : AbpDbContext<WorkFlowDbContext>, IWorkFlowDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public WorkFlowDbContext(DbContextOptions<WorkFlowDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureWorkFlow();
    }
}
