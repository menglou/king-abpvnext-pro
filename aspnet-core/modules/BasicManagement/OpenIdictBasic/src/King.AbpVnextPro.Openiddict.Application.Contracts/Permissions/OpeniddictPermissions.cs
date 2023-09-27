using EasyAbp.Abp.SettingUi.Authorization;
using Volo.Abp.Identity;
using Volo.Abp.Reflection;

namespace King.AbpVnextPro.Openiddict.Permissions;

public class OpeniddictPermissions
{


    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

    public const string LogGroupName = "LogCenter";

    public const string NoticeGroupName = "NoticeCenter";

    //登录日志
    public static class SecurityLogPermissions
    {
        public const string GroupName = LogGroupName + ".SecurityLog";
        public static class SecurityLog
        {
            public const string Default = GroupName + ".Default";
            public const string Delete = GroupName + ".Delete";
        }

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(SecurityLogPermissions));
        }
    }
    //审计日志
    public static class AuditLogPermissions
    {
        public const string GroupName = LogGroupName + ".AbpAuditLogging";
        public static class AuditLogs
        {
            public const string Default = GroupName + ".Default";
            public const string Delete = GroupName + ".Delete";
        }

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(AuditLogPermissions));
        }

    }
    //身份认证
    public static class BasicIdentityPermissions
    {
        public static class Users
        {
            // 分配人员给组织单元权限
            public const string DistributionOrganizationUnit = IdentityPermissions.Users.Default + ".DistributionOrganizationUnit";
            //锁住/解锁
            public const string LoclUnLock = IdentityPermissions.Users.Default + ".LoclUnLock";
            //冻结/解冻
            public const string ActiveIsActive = IdentityPermissions.Users.Default + ".ActiveIsActive";
            public const string RestPwd = IdentityPermissions.Users.Default + ".RestPwd";
        }

        public static class Roles
        {
            public const string AddOrganizationUnitRole = IdentityPermissions.Roles.Default + ".AddOrganizationUnitRole";
        }

        public static class OrganitaionUnits
        {
            public const string Default = IdentityPermissions.GroupName + ".OrganitaionUnits";
            public const string Create = Default + ".Create";
            public const string Update = Default + ".Update";
            public const string Delete = Default + ".Delete";
            public const string CreateRootOrg = Default + ".CreateRootOrg";//根组织
            public const string CreateSubOrg = Default + ".CreateSubOrg";//子组织
            public const string AddUseToOrganization = Default + ".AddUseToOrganization";//添加组织成员
            public const string DeleteUseFromOrganization = Default + ".DeleteUseFromOrganization";//删除组织成员
        }

        public static class ClaimTypes
        {
            public const string Default = IdentityPermissions.GroupName + ".ClaimTypes";
            public const string Create = Default + ".Create";
            public const string Update = Default + ".Update";
            public const string Delete = Default + ".Delete";
        }

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(IdentityPermissions));
        }
    }


    public static class SettingUi
    {
        public static class System
        {
            public const string Default = SettingUiPermissions.GroupName + ".System";
            // 本地化
            public const string Localization = Default + ".Localization";
            //时区
            public const string UTC = Default + ".TimeZone";
            //密码
            public const string Password = Default + ".Password";
            //锁住
            public const string Lock = Default + ".Lockout";
            //登录
            public const string Login = Default + ".SignIn";
            //用户
            public const string User = Default + ".User";
            //组织单元
            public const string Organization = Default + ".OrganizationUnit";
            //账户
            public const string Account = Default + ".Account";
        }

        public static class Mail
        {
            public const string Default = SettingUiPermissions.GroupName + ".Mail";
            // SMTP
            public const string SMTP = Default + ".Smtp";
            //默认发件人信息
            public const string DefaultSendInfo = Default + ".Others";
        }
    }
    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(OpeniddictPermissions));
    }
}
