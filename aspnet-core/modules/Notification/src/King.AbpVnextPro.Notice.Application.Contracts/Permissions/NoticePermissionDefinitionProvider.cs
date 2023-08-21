using King.AbpVnextPro.Notice.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace King.AbpVnextPro.Notice.Permissions;

public class NoticePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NoticePermissions.GroupName, L("Permission:Notice"));

        //公告通知
        var noticecenter = context.AddGroup(NoticePermissions.NoticeGroupName, L("消息中心"));
        noticecenter.AddPermission(NoticePermissions.NoticeMnager.Notice.Default, L("通知公告"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NoticeResource>(name);
    }
}
