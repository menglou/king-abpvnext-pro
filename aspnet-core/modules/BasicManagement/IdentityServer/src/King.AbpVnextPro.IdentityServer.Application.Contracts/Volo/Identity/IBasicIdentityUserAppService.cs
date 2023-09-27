using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Account;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Identity;

namespace King.AbpVnextPro.IdentityServer.Volo.Identity
{
   public interface IBasicIdentityUserAppService: IApplicationService
    {
        Task AddToOrganizationUnitsAsync(Guid userId, List<Guid> ouId);

        /// <summary>
        /// get list OrganizationUnits
        /// </summary>
        /// <param name="id">user id</param>
        /// <param name="includeDetails"></param>
        /// <returns></returns>
        Task<ListResultDto<OrganizationUnitDto>> GetListOrganizationUnitsAsync(Guid id, bool includeDetails = false);


        Task<IdentityUserDto> CreateAsync(IdentityUserOrgCreateDto input);

        Task<IdentityUserDto> UpdateAsync(Guid id, IdentityUserOrgUpdateDto input);

        Task<bool> BatchAddToOrganizationUnitsAsync(BatchUseToOrganizationUnitCreationDto input);
     
        Task<bool> RemoveFromOrganizationUnitAsync(UseToOrganizationUnitDeleteDto input);
        Task<bool> UpdateUseLockAsync(Guid id);
        Task<bool> UpdateUseActiveAsync(UpdateUseActiveDto input);
        Task<bool> RestPassWordAsync(PasswordResetDto input);
        Task<List<IdentityUserDto>> GetListAllAsync();
    }
}
