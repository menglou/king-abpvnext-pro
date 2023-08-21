using King.AbpVnextPro.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace King.AbpVnextPro.Permissions;

public class AbpVnextProPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpVnextProPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpVnextProPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpVnextProResource>(name);
    }
}
