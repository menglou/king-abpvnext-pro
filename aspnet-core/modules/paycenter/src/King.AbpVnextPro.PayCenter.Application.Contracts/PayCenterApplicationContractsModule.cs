using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using King.AbpVnextPro.Paylink.Alipy;
using King.AbpVnextPro.Paylink.WeChat;

namespace King.AbpVnextPro.PayCenter;

[DependsOn(
    typeof(PayCenterDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule),
    typeof(AbpVnextProPaylinkAlipayModule),
    typeof(AbpVnextProPaylinkWeChatModule)
    )]
public class PayCenterApplicationContractsModule : AbpModule
{

}
