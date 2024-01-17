namespace King.AbpVnextPro.File.Settings;

public static class FileSettings
{
    public const string GroupName = "File";

    /* Add constants for setting names. Example:
     * public const string MySettingName = GroupName + ".MySettingName";
     */


    public const string AllowedMaxFileSize = GroupName + ".AllowedMaxFileSize";
    public const string AllowedUploadFormats = GroupName + ".AllowedUploadFormats";
    public const string BaseUploadUrl = GroupName + ".BaseUploadUrl";
}
