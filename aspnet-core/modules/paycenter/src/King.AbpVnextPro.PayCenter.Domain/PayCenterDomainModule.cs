using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.PayCenter;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(PayCenterDomainSharedModule)
)]
public class PayCenterDomainModule : AbpModule
{

}
