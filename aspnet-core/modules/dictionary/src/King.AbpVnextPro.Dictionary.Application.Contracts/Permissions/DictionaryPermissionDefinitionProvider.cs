using King.AbpVnextPro.Dictionary.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace King.AbpVnextPro.Dictionary.Permissions;

public class DictionaryPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var dataDirctionaryGroup = context.AddGroup(DictionaryPermissions.GroupName, L("Permission:DataDictionary"));

        var dictionary = dataDirctionaryGroup.AddPermission(DictionaryPermissions.DataDictionary.Default, L("DataDictionary"));
        dictionary.AddChild(DictionaryPermissions.DataDictionary.Update, L("Edit"));
        dictionary.AddChild(DictionaryPermissions.DataDictionary.Delete, L("Delete"));
        dictionary.AddChild(DictionaryPermissions.DataDictionary.Create, L("Create"));

        var detail = dictionary.AddChild(DictionaryPermissions.DataDictionaryDetail.Default, L("DataDictionaryDetail"));
        detail.AddChild(DictionaryPermissions.DataDictionaryDetail.Update, L("Edit"));
        detail.AddChild(DictionaryPermissions.DataDictionaryDetail.Delete, L("Delete"));
        detail.AddChild(DictionaryPermissions.DataDictionaryDetail.Create, L("Create"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DictionaryResource>(name);
    }
}
