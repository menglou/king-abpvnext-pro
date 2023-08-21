using King.AbpVnextPro.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace King.AbpVnextPro.CAP;
public class AbpVnextProCapPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var abpIdentityGroup = context.GetGroup(AbpVnextProCapPermissions.CapManagement.Default);

        abpIdentityGroup.AddPermission(AbpVnextProCapPermissions.CapManagement.Cap, L("Permission:Cap"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpVnextProLocalizationResource>(name);
    }
}