using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.ScheduleTask;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ScheduleTaskDomainSharedModule)
)]
public class ScheduleTaskDomainModule : AbpModule
{

}
