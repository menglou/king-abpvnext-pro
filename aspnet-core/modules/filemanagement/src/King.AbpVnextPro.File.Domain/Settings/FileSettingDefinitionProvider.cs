using King.AbpVnextPro.File.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace King.AbpVnextPro.File.Settings;

public class FileSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        /* Define module settings here.
         * Use names from FileSettings class.
         */

        context.Add(new SettingDefinition(
                FileSettings.AllowedMaxFileSize,
                "1024",
                L("DisplayName:FileManagement.AllowedMaxFileSize"),
                L("Description:FileManagement.AllowedMaxFileSize")
                )
                    .WithProperty("Group1", "File")
                    .WithProperty("Group2", "Upload")
                    .WithProperty("Type", "number"),

                new SettingDefinition(
                    FileSettings.AllowedUploadFormats,
                    ".jpg,.jpeg,.png,.gif,.txt",
                    L("DisplayName:FileManagement.AllowedUploadFormats"),
                    L("Description:FileManagement.AllowedUploadFormats")
                )
                    .WithProperty("Group1", "File")
                    .WithProperty("Group2", "Upload")
                    .WithProperty("Type", "text"),

                new SettingDefinition(
                    FileSettings.BaseUploadUrl,
                    "",
                    L("DisplayName:FileManagement.BaseUploadUrl"),
                    L("Description:FileManagement.BaseUploadUrl")
                )
                    .WithProperty("Group1", "File")
                    .WithProperty("Group2", "Upload")
                    .WithProperty("Type", "text")
                
                );
    }
    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FileResource>(name);
    }
}
