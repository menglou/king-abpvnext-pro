using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.WorkFlow;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(WorkFlowDomainSharedModule)
)]
public class WorkFlowDomainModule : AbpModule
{

}
