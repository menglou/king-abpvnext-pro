using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace King.AbpVnextPro.WorkFlow;

[DependsOn(
    typeof(WorkFlowDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class WorkFlowApplicationContractsModule : AbpModule
{

}
