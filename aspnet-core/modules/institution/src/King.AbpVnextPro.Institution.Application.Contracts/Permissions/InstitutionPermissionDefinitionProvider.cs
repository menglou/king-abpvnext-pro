using King.AbpVnextPro.Institution.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace King.AbpVnextPro.Institution.Permissions;

public class InstitutionPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var intitutionGroup = context.AddGroup(InstitutionPermissions.GroupName, L("Permission:Institution"));

        var departmentunitper = intitutionGroup.AddPermission(InstitutionPermissions.DepartmentUnit.Default, L("Permission:DepartmentUnit"));
        departmentunitper.AddChild(InstitutionPermissions.DepartmentUnit.Create, L("Permission:Create"));
        departmentunitper.AddChild(InstitutionPermissions.DepartmentUnit.Update, L("Permission:Update"));
        departmentunitper.AddChild(InstitutionPermissions.DepartmentUnit.Delete, L("Permission:Delete"));
        departmentunitper.AddChild(InstitutionPermissions.DepartmentUnit.CreateChild, L("Permission:CreateChild"));
        departmentunitper.AddChild(InstitutionPermissions.DepartmentUnit.BindUser, L("Permission:BindUser"));


        var posterper = intitutionGroup.AddPermission(InstitutionPermissions.Poster.Default, L("Permission:Poster"));
        posterper.AddChild(InstitutionPermissions.Poster.Create, L("Permission:Create"));
        posterper.AddChild(InstitutionPermissions.Poster.Update, L("Permission:Update"));
        posterper.AddChild(InstitutionPermissions.Poster.Delete, L("Permission:Delete"));
        posterper.AddChild(InstitutionPermissions.Poster.BindUser, L("Permission:BindUser"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<InstitutionResource>(name);
    }
}
