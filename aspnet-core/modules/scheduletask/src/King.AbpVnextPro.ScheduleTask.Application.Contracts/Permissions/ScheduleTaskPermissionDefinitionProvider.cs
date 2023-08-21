using King.AbpVnextPro.ScheduleTask.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace King.AbpVnextPro.ScheduleTask.Permissions;

public class ScheduleTaskPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var scheduletaskGroup = context.AddGroup(ScheduleTaskPermissions.GroupName, L("Permission:ScheduleTaskManager"));

        var scheduletaskper=  scheduletaskGroup.AddPermission(ScheduleTaskPermissions.ScheduleTask.Default,L("Permission:ScheduleTask"));
        scheduletaskper.AddChild(ScheduleTaskPermissions.ScheduleTask.Create, L("Permission:Create"));
        scheduletaskper.AddChild(ScheduleTaskPermissions.ScheduleTask.Update, L("Permission:Update"));
        scheduletaskper.AddChild(ScheduleTaskPermissions.ScheduleTask.Delete, L("Permission:Delete"));
        scheduletaskper.AddChild(ScheduleTaskPermissions.ScheduleTask.Start, L("Permission:Start"));
        scheduletaskper.AddChild(ScheduleTaskPermissions.ScheduleTask.Stop, L("Permission:Stop"));
        scheduletaskper.AddChild(ScheduleTaskPermissions.ScheduleTask.Pause, L("Permission:Pause"));
        scheduletaskper.AddChild(ScheduleTaskPermissions.ScheduleTask.Resume, L("Permission:Resume"));
        scheduletaskper.AddChild(ScheduleTaskPermissions.ScheduleTask.RunOnce, L("Permission:RunOnce"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ScheduleTaskResource>(name);
    }
}
