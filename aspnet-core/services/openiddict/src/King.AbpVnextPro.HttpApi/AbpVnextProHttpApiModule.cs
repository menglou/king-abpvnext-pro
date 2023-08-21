using Localization.Resources.AbpUi;
using King.AbpVnextPro.Localization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using King.AbpVnextPro.Openiddict;
using King.AbpVnextPro.Notice;
using King.AbpVnextPro.Dictionary;
using King.AbpVnextPro.File;
using King.AbpVnextPro.ScheduleTask;
using EasyAbp.Abp.SettingUi;
using King.AbpVnextPro.PayCenter;
using King.AbpVnextPro.Institution;

namespace King.AbpVnextPro;

[DependsOn(
    typeof(AbpVnextProApplicationContractsModule),
    typeof(AbpSettingUiHttpApiModule),
    typeof(OpeniddictHttpApiModule),
    typeof(NoticeHttpApiModule),
    typeof(DictionaryHttpApiModule),
    typeof(FileHttpApiModule),
    typeof(ScheduleTaskHttpApiModule),
    typeof(PayCenterHttpApiModule),
    typeof(InstitutionHttpApiModule)
    )]
public class AbpVnextProHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AbpVnextProResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
