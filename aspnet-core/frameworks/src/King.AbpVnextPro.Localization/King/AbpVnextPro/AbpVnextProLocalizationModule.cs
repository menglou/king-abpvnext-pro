namespace King.AbpVnextPro;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpLocalizationModule)
)]
public class AbpVnextProLocalizationModule: AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options => { options.FileSets.AddEmbedded<AbpVnextProLocalizationModule>(AbpVnextProLocalizationConsts.NameSpace); });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<AbpVnextProLocalizationResource>(AbpVnextProLocalizationConsts.DefaultCultureName)
                .AddVirtualJson(AbpVnextProLocalizationConsts.DefaultLocalizationResourceVirtualPath);

            options.DefaultResourceType = typeof(AbpVnextProLocalizationResource);
        });

        Configure<AbpExceptionLocalizationOptions>(options => { options.MapCodeNamespace(AbpVnextProLocalizationConsts.NameSpace, typeof(AbpVnextProLocalizationResource)); });
    }
}