using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using King.AbpVnextPro.MultiTenancy;
using Volo.Abp.Emailing;
using Volo.Abp.IdentityServer;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;
using King.AbpVnextPro.IdentityServer;
using Volo.Abp.PermissionManagement.IdentityServer;
using King.AbpVnextPro.Notice;
using King.AbpVnextPro.Dictionary;
using King.AbpVnextPro.File;
using King.AbpVnextPro.ScheduleTask;
using King.AbpVnextPro.PayCenter;
using King.AbpVnextPro.Institution;

namespace King.AbpVnextPro;
[DependsOn(
    typeof(AbpVnextProDomainSharedModule),
    typeof(IdentityServerDomainModule),
    typeof(AbpPermissionManagementDomainIdentityServerModule),
    typeof(AbpIdentityServerDomainModule),
    typeof(NoticeDomainModule),
    typeof(DictionaryDomainModule),
    typeof(FileDomainModule),
    typeof(ScheduleTaskDomainModule),
    typeof(PayCenterDomainModule),
    typeof(InstitutionDomainModule)
)]
public class AbpVnextProDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpMultiTenancyOptions>(options =>
        {
            options.IsEnabled = MultiTenancyConsts.IsEnabled;
        });

#if DEBUG
        context.Services.Replace(ServiceDescriptor.Singleton<IEmailSender, NullEmailSender>());
#endif
    }
}
