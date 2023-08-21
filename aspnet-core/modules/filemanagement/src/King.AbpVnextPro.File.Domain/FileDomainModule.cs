using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.File;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(FileDomainSharedModule)
)]
public class FileDomainModule : AbpModule
{

}
