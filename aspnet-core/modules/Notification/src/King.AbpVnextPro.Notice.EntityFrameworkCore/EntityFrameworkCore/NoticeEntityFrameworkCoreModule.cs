using King.AbpVnextPro.Notice.Notifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.DependencyInjection;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.Notice.EntityFrameworkCore;

[DependsOn(
    typeof(NoticeDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class NoticeEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<NoticeDbContext>(options =>
        {
            /* Add custom repositories here. Example:
             * options.AddRepository<Question, EfCoreQuestionRepository>();
             */
            options.AddDefaultRepositories(true);
        });

        Configure<AbpEntityOptions>(options =>
        {
            options.Entity<Notification>(notificationOptions =>
            {
                notificationOptions.DefaultWithDetailsFunc = query => query.Include(o => o.NotificationSubscriptions);
            });
        });
    }
}
