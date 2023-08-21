
namespace King.AbpVnextPro.Cli;

[DependsOn(
    typeof(AbpVnextProCliCoreModule),
    typeof(AbpAutofacModule)
)]
public class AbpVnextProCliModule: AbpModule
{
}