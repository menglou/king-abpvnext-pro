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
    DbSet<ScheduleEntity> ScheduleEntity { get; }
    DbSet<ScheduleHttpOptionEntity> ScheduleHttpOptionEntity { get; }
    DbSet<ScheduleKeeperEntity> ScheduleKeeperEntity { get; }
    DbSet<ScheduleLogEntity> ScheduleLogEntity{ get; }
}
