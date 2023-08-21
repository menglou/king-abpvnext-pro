using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.ScheduleTask.EntityFrameworkCore;

public class ScheduleTaskHttpApiHostMigrationsDbContext : AbpDbContext<ScheduleTaskHttpApiHostMigrationsDbContext>
{
    public ScheduleTaskHttpApiHostMigrationsDbContext(DbContextOptions<ScheduleTaskHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureScheduleTask();
    }
}
