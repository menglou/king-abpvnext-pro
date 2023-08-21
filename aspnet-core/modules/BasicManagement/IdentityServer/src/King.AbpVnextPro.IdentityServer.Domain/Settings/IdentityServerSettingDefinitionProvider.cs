using King.AbpVnextPro.IdentityServer.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace King.AbpVnextPro.IdentityServer.Settings;

public class IdentityServerSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        /* Define module settings here.
         * Use names from IdentityServerSettings class.
         */

        context.Add(new SettingDefinition(
              IdentityServerSettings.SettHttpTimeOut,
              "300",
              L("DisplayName:Http.HttpTimeOut"),
              L("Description:Http.HttpTimeOut")
              )
                  .WithProperty("Group1", "Http")
                  .WithProperty("Group2", "TimeOut")
                  .WithProperty("Type", "number")
              );
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<IdentityServerResource>(name);
    }
}
