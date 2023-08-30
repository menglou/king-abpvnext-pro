using Volo.Abp.BlobStoring;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace King.AbpVnextPro.File;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(FileDomainSharedModule),
    typeof(AbpBlobStoringModule)
)]
public class FileDomainModule : AbpModule
{

}
