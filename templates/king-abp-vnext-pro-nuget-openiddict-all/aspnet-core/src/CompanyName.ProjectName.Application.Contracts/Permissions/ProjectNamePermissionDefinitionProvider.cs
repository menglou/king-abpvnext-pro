using CompanyName.ProjectName.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CompanyName.ProjectName.Permissions;

public class ProjectNamePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProjectNamePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ProjectNamePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProjectNameResource>(name);
    }
}
