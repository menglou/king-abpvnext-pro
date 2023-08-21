using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace King.AbpVnextPro;

[Dependency(ReplaceServices = true)]
public class AbpVnextProBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpVnextPro";
}
