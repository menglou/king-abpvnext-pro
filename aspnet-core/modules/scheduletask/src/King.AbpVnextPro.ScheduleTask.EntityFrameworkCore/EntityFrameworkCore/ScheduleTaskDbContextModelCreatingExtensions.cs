using King.AbpVnextPro.ScheduleTask.Schedules;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace King.AbpVnextPro.ScheduleTask.EntityFrameworkCore;

public static class ScheduleTaskDbContextModelCreatingExtensions
{
    public static void ConfigureScheduleTask(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(ScheduleTaskDbProperties.DbTablePrefix + "Questions", ScheduleTaskDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */
        builder.Entity<ScheduleEntity>(b =>
        {
            b.ToTable("Schedule", ScheduleTaskDbProperties.DbSchema);
            b.ConfigureConcurrencyStamp();
            b.ConfigureExtraProperties();
            b.ConfigureAudited();
            b.Property(x => x.Title).IsRequired().HasMaxLength(100);
            b.Property(x => x.CronExpression).HasMaxLength(50);
            b.Property(x => x.AssemblyName).HasMaxLength(200);
            b.Property(x => x.ClassName).HasMaxLength(200);
            b.Property(x => x.Remark).HasDefaultValue(500);
            b.HasIndex(q => q.Title);
        });

        builder.Entity<ScheduleHttpOptionEntity>(b =>
        {
            b.ToTable("ScheduleHttpOption", ScheduleTaskDbProperties.DbSchema);
            b.ConfigureConcurrencyStamp();
            b.ConfigureExtraProperties();
            b.ConfigureAudited();
            b.Property(x => x.RequestUrl).IsRequired().HasMaxLength(500);
            b.Property(x => x.Method).IsRequired().HasMaxLength(10);
            b.Property(x => x.ContentType).IsRequired().HasMaxLength(50);

            b.HasIndex(q => q.ScheduleId);
        });

        builder.Entity<ScheduleLogEntity>(b =>
        {
            b.ToTable("ScheduleLog", ScheduleTaskDbProperties.DbSchema);
            b.ConfigureConcurrencyStamp();
            b.ConfigureExtraProperties();
            b.ConfigureAudited();
            b.HasIndex(q => q.ScheduleId);
        });

        builder.Entity<ScheduleKeeperEntity>(b =>
        {
            b.ToTable("ScheduleKeeper", ScheduleTaskDbProperties.DbSchema);
            b.ConfigureConcurrencyStamp();
            b.ConfigureExtraProperties();
            b.ConfigureAudited();
            b.HasIndex(q => q.ScheduleId);
        });
    }
}
