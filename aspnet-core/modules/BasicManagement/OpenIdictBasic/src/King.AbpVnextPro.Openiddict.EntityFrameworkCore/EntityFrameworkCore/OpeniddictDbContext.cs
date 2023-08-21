using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.Openiddict.EntityFrameworkCore;

[ConnectionStringName(OpeniddictDbProperties.ConnectionStringName)]
public class OpeniddictDbContext : AbpDbContext<OpeniddictDbContext>, IOpeniddictDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public OpeniddictDbContext(DbContextOptions<OpeniddictDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureOpeniddict();
    }
}
