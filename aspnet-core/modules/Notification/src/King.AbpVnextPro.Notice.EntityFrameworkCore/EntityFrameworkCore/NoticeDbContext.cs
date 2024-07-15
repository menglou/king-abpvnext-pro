using King.AbpVnextPro.Notice.Notifications;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.Notice.EntityFrameworkCore;

[ConnectionStringName(NoticeDbProperties.ConnectionStringName)]
public class NoticeDbContext : AbpDbContext<NoticeDbContext>, INoticeDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */



    public NoticeDbContext(DbContextOptions<NoticeDbContext> options)
        : base(options)
    {

    }

    public virtual DbSet<Notification> Notification { get ; set; }
  
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureNotice();
    }
}
