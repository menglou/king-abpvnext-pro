using Volo.Abp.Reflection;

namespace King.AbpVnextPro.Institution.Permissions;

public class InstitutionPermissions
{
    public const string GroupName = "Institution";

    public static class DepartmentUnit
    {
        public const string Default = GroupName + ".DepartmentUnit";
        public const string Create = Default + ".Create";
        public const string CreateChild = Default + ".CreateChild";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
        public const string BindUser = Default + ".BindUser";
        
    }

    public static class Poster
    {
        public const string Default = GroupName + ".Poster";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
        public const string BindUser = Default + ".BindUser";
    }

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(InstitutionPermissions));
    }
}
