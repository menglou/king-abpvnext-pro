using EasyAbp.Abp.SettingUi.Authorization;
using King.AbpVnextPro.PayCenter.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using static King.AbpVnextPro.PayCenter.Permissions.PayCenterPermissions;

namespace King.AbpVnextPro.PayCenter.Permissions;

public class PayCenterPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var settingUIPage = context.GetPermissionOrNull(SettingUiPermissions.ShowSettingPage);
        var payCenterGroup = settingUIPage.AddChild(SettingUi.PayCenter.Default, L("Permission:PayCenter"));
        payCenterGroup.AddChild(SettingUi.PayCenter.WechatPay, L("Permission:PayCenter.Wechat"));
        payCenterGroup.AddChild(SettingUi.PayCenter.AliPay, L("Permission:PayCenter.Alipay"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PayCenterResource>(name);
    }
}
