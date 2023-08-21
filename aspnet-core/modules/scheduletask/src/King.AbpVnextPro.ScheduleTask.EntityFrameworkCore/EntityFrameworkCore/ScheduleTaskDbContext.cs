using King.AbpVnextPro.ScheduleTask.Schedules;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.ScheduleTask.EntityFrameworkCore;

[ConnectionStringName(ScheduleTaskDbProperties.ConnectionStringName)]
public class ScheduleTaskDbContext : AbpDbContext<ScheduleTaskDbContext>, IScheduleTaskDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public ScheduleTaskDbContext(DbContextOptions<ScheduleTaskDbContext> options)
        : base(options)
    {

    }

    public DbSet<ScheduleEntity> ScheduleEntitys { get; set; }

    public DbSet<ScheduleHttpOptionEntity> ScheduleHttpOptionEntitys { get; set; }

    public DbSet<ScheduleKeeperEntity> ScheduleKeeperEntitys { get; set; }

    public DbSet<ScheduleLogEntity> ScheduleLogEntitys { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureScheduleTask();
    }
}
