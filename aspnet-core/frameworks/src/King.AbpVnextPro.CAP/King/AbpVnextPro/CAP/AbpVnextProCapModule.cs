
namespace King.AbpVnextPro.CAP;

[DependsOn(
    typeof(AbpEventBusModule), 
    typeof(AbpVnextProLocalizationModule),
    typeof(AbpUnitOfWorkModule))]
public class AbpVnextProCapModule : AbpModule
{
}