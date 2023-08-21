using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.Dictionary;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(DictionaryDomainSharedModule)
)]
public class DictionaryDomainModule : AbpModule
{

}
