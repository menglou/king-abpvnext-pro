using Volo.Abp.Reflection;

namespace King.AbpVnextPro.Notice.Permissions;

public class NoticePermissions
{
    public const string GroupName = "Notice";

    public const string NoticeGroupName = "NoticeCenter";
    public static class NoticeMnager
    {
        public static class Notice
        {
            public const string Default = NoticeGroupName + ".Notice";
        }
    }

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(NoticePermissions));
    }
}
