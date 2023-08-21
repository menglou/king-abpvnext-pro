using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace King.AbpVnextPro.Notice;

[DependsOn(
    typeof(NoticeDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class NoticeApplicationContractsModule : AbpModule
{

}
