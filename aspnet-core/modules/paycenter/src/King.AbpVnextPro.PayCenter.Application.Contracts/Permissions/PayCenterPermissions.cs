using EasyAbp.Abp.SettingUi.Authorization;
using Volo.Abp.Reflection;

namespace King.AbpVnextPro.PayCenter.Permissions;

public class PayCenterPermissions
{
    public const string GroupName = "PayCenter";

    public static class SettingUi
    {
        public static class PayCenter
        {
            public const string Default = SettingUiPermissions.GroupName + ".PayCenter";
            // 本地化
            public const string WechatPay = Default + ".WechatPay";
            //时区
            public const string AliPay = Default + ".AliPay";
        }
    }
    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(PayCenterPermissions));
    }
}
