using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace King.AbpVnextPro.Dictionary;

[DependsOn(
    typeof(DictionaryDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class DictionaryApplicationContractsModule : AbpModule
{

}
