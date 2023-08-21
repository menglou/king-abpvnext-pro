using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.PayCenter.EntityFrameworkCore;

[ConnectionStringName(PayCenterDbProperties.ConnectionStringName)]
public class PayCenterDbContext : AbpDbContext<PayCenterDbContext>, IPayCenterDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public PayCenterDbContext(DbContextOptions<PayCenterDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigurePayCenter();
    }
}
