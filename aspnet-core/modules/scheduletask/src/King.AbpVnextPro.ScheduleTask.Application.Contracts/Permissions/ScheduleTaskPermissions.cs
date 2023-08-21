using Volo.Abp.Reflection;

namespace King.AbpVnextPro.ScheduleTask.Permissions;

public class ScheduleTaskPermissions
{
    public const string GroupName = "ScheduleTaskManager";

    public static class ScheduleTask
    {
        public const string Default = GroupName + ".ScheduleTask";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
        public const string Start = Default + ".Start";
        public const string Stop = Default + ".Stop";
        public const string Pause = Default + ".Pause";
        public const string Resume = Default + ".Resume";
        public const string RunOnce = Default + ".RunOnce";
    }

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ScheduleTaskPermissions));
    }
}
