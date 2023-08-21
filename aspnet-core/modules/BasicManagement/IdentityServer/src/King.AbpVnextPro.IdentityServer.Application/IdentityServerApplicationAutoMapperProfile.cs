using AutoMapper;
using King.AbpVnextPro.IdentityServer.Logs.AuditLogging;
using King.AbpVnextPro.IdentityServer.Logs.SecurityLogs;
using King.AbpVnextPro.IdentityServer.Volo.Identity;
using Volo.Abp.AuditLogging;
using Volo.Abp.Identity;

namespace King.AbpVnextPro.IdentityServer;

public class IdentityServerApplicationAutoMapperProfile : Profile
{
    public IdentityServerApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<OrganizationUnit, OrganizationUnitDto>().MapExtraProperties();

        CreateMap<IdentityUserOrgCreateDto, IdentityUserCreateDto>();
        CreateMap<IdentityUserOrgUpdateDto, IdentityUserUpdateDto>();
        CreateMap<IdentityRoleOrgCreateDto, IdentityRoleCreateDto>();

        #region AuditLog
        //AuditLog
        CreateMap<AuditLog, AuditLogDto>().MapExtraProperties();

        CreateMap<EntityChange, EntityChangeDto>().MapExtraProperties();

        CreateMap<EntityPropertyChange, EntityPropertyChangeDto>();

        CreateMap<AuditLogAction, AuditLogActionDto>();
        #endregion

        #region  SecurityLog
        CreateMap<IdentitySecurityLog, SecurityLogDto>();
        #endregion
    }
}
