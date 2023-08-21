using King.AbpVnextPro.WorkFlow.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace King.AbpVnextPro.WorkFlow.Permissions;

public class WorkFlowPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(WorkFlowPermissions.GroupName, L("Permission:WorkFlow"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<WorkFlowResource>(name);
    }
}
