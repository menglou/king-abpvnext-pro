using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace King.AbpVnextPro;

[Dependency(ReplaceServices = true)]
public class AbpVnextProBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpVnextPro";
}
