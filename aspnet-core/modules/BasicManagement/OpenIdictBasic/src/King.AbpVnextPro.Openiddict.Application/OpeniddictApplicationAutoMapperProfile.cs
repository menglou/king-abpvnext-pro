using AutoMapper;
using King.AbpVnextPro.Openiddict.Logs.AuditLogging;
using King.AbpVnextPro.Openiddict.Logs.SecurityLogs;
using King.AbpVnextPro.Openiddict.Volo.Identity;
using Volo.Abp.AuditLogging;
using Volo.Abp.Identity;

namespace King.AbpVnextPro.Openiddict;

public class OpeniddictApplicationAutoMapperProfile : Profile
{
    public OpeniddictApplicationAutoMapperProfile()
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
