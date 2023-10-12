using Volo.Abp.Modularity;
using Volo.Abp.OpenIddict.ExtensionGrantTypes;

namespace CompanyName.ProjectName
{
    public static class VerifyGrantValidatorExtensions
    {
        public static OpenIddictServerBuilder AllowVerifyFlow(this OpenIddictServerBuilder builder)
        {
            return builder.AllowCustomFlow(VerifyCodeExtensionGrantConsts.GrantType);
        }

        public static IServiceCollection SetVerifyOptions(this ServiceConfigurationContext context)
        {
            return context.Services.Configure<AbpOpenIddictExtensionGrantsOptions>(optioons =>
            {
                optioons.Grants.Add(VerifyCodeExtensionGrantConsts.GrantType, new VertifyValidateController());
            });
        }
    }
}
