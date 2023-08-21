using King.AbpVnextPro.Notice.Notifications;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace King.AbpVnextPro.Notice.EntityFrameworkCore;

public static class NoticeDbContextModelCreatingExtensions
{
    public static void ConfigureNotice(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<Notification>(b =>
        {
            b.ToTable("Notification", NoticeDbProperties.DbSchema);
            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(256);
            b.Property(q => q.Content).IsRequired().HasColumnType("text");
            //Relations
            b.HasMany(question => question.NotificationSubscriptions).WithOne().HasForeignKey(qt => qt.NotificationId).IsRequired();
            b.ConfigureByConvention();


        });
        builder.Entity<NotificationSubscription>(b =>
        {
            b.ToTable("NotificationSubscription", NoticeDbProperties.DbSchema);
            b.ConfigureByConvention();
        });
    }
}
