using King.AbpVnextPro.Institution.Departments;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Domain;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.ObjectExtending.Modularity;
using Volo.Abp.Security.Claims;
using Volo.Abp.Threading;
using Volo.Abp.Users;

namespace King.AbpVnextPro.Institution;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(InstitutionDomainSharedModule)
)]
public class InstitutionDomainModule : AbpModule
{

    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
    }

}
