
using EasyAbp.Abp.SettingUi.Authorization;
using Volo.Abp.Reflection;

namespace King.AbpVnextPro.File.Permissions;

public class FilePermissions
{
    public const string GroupName = "File";


    public static class SettingUi
    {
        public static class File
        {
            public const string Default = SettingUiPermissions.GroupName + ".File";
            // 本地化
            public const string AllowMaxUpload = Default + ".AllowMaxUpload";
            //时区
            public const string AllowUploadFomart = Default + ".AllowUploadFomart";
        }
    }

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(FilePermissions));
    }
}
