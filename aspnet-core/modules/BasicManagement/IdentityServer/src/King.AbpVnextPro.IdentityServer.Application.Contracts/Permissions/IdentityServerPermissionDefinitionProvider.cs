using EasyAbp.Abp.SettingUi.Authorization;
using King.AbpVnextPro.IdentityServer.Localization;
using Volo.Abp.AuditLogging.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity;
using Volo.Abp.Identity.Localization;
using Volo.Abp.Localization;
using Volo.Abp.SettingManagement;
using static King.AbpVnextPro.IdentityServer.Permissions.IdentityServerPermissions;

namespace King.AbpVnextPro.IdentityServer.Permissions;

public class IdentityServerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        // var myGroup = context.AddGroup(IdentityServerPermissions.GroupName, L("Permission:IdentityServer"));

        //禁掉 原来的设置管理
        context.GetPermissionOrNull(SettingManagementPermissions.Emailing).IsEnabled = false;

        var identityGroup = context.GetGroup(IdentityPermissions.GroupName);

        var ouPermission = identityGroup.AddPermission(BasicIdentityPermissions.OrganitaionUnits.Default, IdentityL("Permission:OrganitaionUnitManagement"));
        ouPermission.AddChild(BasicIdentityPermissions.OrganitaionUnits.Create, IdentityL("Permission:Create"));//添加根组织
        ouPermission.AddChild(BasicIdentityPermissions.OrganitaionUnits.Update, IdentityL("Permission:Edit"));//修改组织
        ouPermission.AddChild(BasicIdentityPermissions.OrganitaionUnits.Delete, IdentityL("Permission:Delete"));


        var users = identityGroup.GetPermissionOrNull(IdentityPermissions.Users.Default);
        users?.AddChild(BasicIdentityPermissions.Users.DistributionOrganizationUnit, IdentityL("Permission:DistributionOrganizationUnit"));

        users?.AddChild(BasicIdentityPermissions.Users.LoclUnLock, L("锁住/解锁"));
        users?.AddChild(BasicIdentityPermissions.Users.ActiveIsActive, L("冻结/激活"));

        //设置管理
        var settingUiPage = context.GetPermissionOrNull(SettingUiPermissions.ShowSettingPage);  // Get ShowSettingPage permission
                                                                                                //系统配置
        var systemGroup = settingUiPage.AddChild(SettingUi.System.Default, L("系统设置")); // Add display permission of Group1: System
        systemGroup.AddChild(SettingUi.System.Localization, L("本地化"));
        systemGroup.AddChild(SettingUi.System.UTC, L("时区"));
        systemGroup.AddChild(SettingUi.System.Password, L("密码"));
        systemGroup.AddChild(SettingUi.System.Lock, L("锁定"));
        systemGroup.AddChild(SettingUi.System.Login, L("登录"));
        systemGroup.AddChild(SettingUi.System.User, L("用户"));
        systemGroup.AddChild(SettingUi.System.Organization, L("组织单元"));
        systemGroup.AddChild(SettingUi.System.Account, L("账户"));

        //邮件配置
        var mailGroup = settingUiPage.AddChild(SettingUi.Mail.Default, L("邮件设置")); // Add display permission of Group1: System
        mailGroup.AddChild(SettingUi.Mail.SMTP, L("SMTP"));
        mailGroup.AddChild(SettingUi.Mail.DefaultSendInfo, L("默认发件人配置"));

        //日志中心
        var logcenter = context.AddGroup(IdentityServerPermissions.LogGroupName, L("日志中心"));

        var aduditLogPermission = logcenter.AddPermission(AuditLogPermissions.AuditLogs.Default, L("审计日志"));
        aduditLogPermission.AddChild(AuditLogPermissions.AuditLogs.Delete, AuditLoggingL("删除"));

        var securityLogPermission = logcenter.AddPermission(SecurityLogPermissions.SecurityLog.Default, L("登录日志"));
        securityLogPermission.AddChild(SecurityLogPermissions.SecurityLog.Delete, AuditLoggingL("删除"));

    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<IdentityServerResource>(name);
    }

    private static LocalizableString IdentityL(string name)
    {
        return LocalizableString.Create<IdentityResource>(name);
    }

    private static LocalizableString AuditLoggingL(string name)
    {
        return LocalizableString.Create<AuditLoggingResource>(name);
    }
}
