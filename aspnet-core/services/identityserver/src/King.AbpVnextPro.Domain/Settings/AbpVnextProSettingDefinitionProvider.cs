using Volo.Abp.Settings;

namespace King.AbpVnextPro.Settings;

public class AbpVnextProSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpVnextProSettings.MySetting1));
    }
}
