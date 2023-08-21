using King.AbpVnextPro.ScheduleTask.Schedules;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.ScheduleTask.EntityFrameworkCore;

[ConnectionStringName(ScheduleTaskDbProperties.ConnectionStringName)]
public interface IScheduleTaskDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
    DbSet<ScheduleEntity> ScheduleEntitys { get; }
    DbSet<ScheduleHttpOptionEntity> ScheduleHttpOptionEntitys { get; }
    DbSet<ScheduleKeeperEntity> ScheduleKeeperEntitys { get; }
    DbSet<ScheduleLogEntity> ScheduleLogEntitys { get; }
}
