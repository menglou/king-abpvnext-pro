using Volo.Abp.Reflection;

namespace King.AbpVnextPro.WorkFlow.Permissions;

public class WorkFlowPermissions
{
    public const string GroupName = "WorkFlow";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(WorkFlowPermissions));
    }
}
