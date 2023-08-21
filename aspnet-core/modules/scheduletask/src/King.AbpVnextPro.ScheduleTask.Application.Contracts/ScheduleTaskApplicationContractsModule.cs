using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace King.AbpVnextPro.ScheduleTask;

[DependsOn(
    typeof(ScheduleTaskDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class ScheduleTaskApplicationContractsModule : AbpModule
{

}
