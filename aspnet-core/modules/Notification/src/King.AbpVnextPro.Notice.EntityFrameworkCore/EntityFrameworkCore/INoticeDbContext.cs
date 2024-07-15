using King.AbpVnextPro.Notice.Notifications;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.Notice.EntityFrameworkCore;

[ConnectionStringName(NoticeDbProperties.ConnectionStringName)]
public interface INoticeDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */

    DbSet<Notification> Notification { get; }
}
