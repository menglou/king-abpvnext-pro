using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace King.AbpVnextPro.Institution;

[DependsOn(
    typeof(InstitutionDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class InstitutionApplicationContractsModule : AbpModule
{

}
