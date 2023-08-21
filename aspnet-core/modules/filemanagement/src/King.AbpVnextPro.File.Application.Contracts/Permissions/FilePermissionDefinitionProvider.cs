using EasyAbp.Abp.SettingUi.Authorization;
using King.AbpVnextPro.File.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using static King.AbpVnextPro.File.Permissions.FilePermissions;

namespace King.AbpVnextPro.File.Permissions;

public class FilePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        //var myGroup = context.AddGroup(FilePermissions.GroupName, L("Permission:File"));


        var settingUiPage = context.GetPermissionOrNull(SettingUiPermissions.ShowSettingPage);  // Get ShowSettingPage permission
        var fileGroup = settingUiPage.AddChild(SettingUi.File.Default, L("Permission:File")); // Add display permission of Group1: System
        fileGroup.AddChild(SettingUi.File.AllowMaxUpload, L("Permission:FileManagement.AllowedMaxFileSize"));
        fileGroup.AddChild(SettingUi.File.AllowUploadFomart, L("Permission:FileManagement.AllowedUploadFormats"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FileResource>(name);
    }
}
