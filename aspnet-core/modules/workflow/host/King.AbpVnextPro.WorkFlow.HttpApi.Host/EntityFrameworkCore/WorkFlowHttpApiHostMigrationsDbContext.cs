using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.WorkFlow.EntityFrameworkCore;

public class WorkFlowHttpApiHostMigrationsDbContext : AbpDbContext<WorkFlowHttpApiHostMigrationsDbContext>
{
    public WorkFlowHttpApiHostMigrationsDbContext(DbContextOptions<WorkFlowHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureWorkFlow();
    }
}
