using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Identity;
using static King.AbpVnextPro.IdentityServer.Permissions.IdentityServerPermissions;

namespace King.AbpVnextPro.IdentityServer.Volo.Identity
{
    [RemoteService(Name = IdentityRemoteServiceConsts.RemoteServiceName)]
    [Area("identity")]
    [ControllerName("User")]
    [Route("api/identity/users")]
    public class BasicIdentityUserController : AbpController, IBasicIdentityUserAppService
    {
        protected IBasicIdentityUserAppService UserAppService { get; }
        public BasicIdentityUserController(IBasicIdentityUserAppService userAppService)
        {
            UserAppService = userAppService;
        }
        /// <summary>
        /// Add members to the organizational unit
        /// </summary>
        /// <param name="userId">userId</param>
        /// <param name="ouIds">ouId</param>
        /// <returns></returns>
        [HttpPost]
        [Route("{userId}/add-to-organizations")]
        public virtual Task AddToOrganizationUnitsAsync(Guid userId, List<Guid> ouIds)
        {
            return UserAppService.AddToOrganizationUnitsAsync(userId, ouIds);
        }
        [HttpPost]
        [Route("batch-add-to-organizations")]
        public virtual Task<bool> BatchAddToOrganizationUnitsAsync(BatchUseToOrganizationUnitCreationDto input)
        {
            return UserAppService.BatchAddToOrganizationUnitsAsync(input);
        }

        [HttpPost]
        [Route("create-to-organizations")]
        public virtual Task<IdentityUserDto> CreateAsync(IdentityUserOrgCreateDto input)
        {
            return UserAppService.CreateAsync(input);
        }

        [HttpGet]
        [Route("{id}/organizations")]
        public virtual Task<ListResultDto<OrganizationUnitDto>> GetListOrganizationUnitsAsync(Guid id, bool includeDetails = false)
        {
            return UserAppService.GetListOrganizationUnitsAsync(id, includeDetails);
        }

        [HttpPut]
        [Route("{id}/update-to-organizations")]
        public virtual Task<IdentityUserDto> UpdateAsync(Guid id, IdentityUserOrgUpdateDto input)
        {
            return UserAppService.UpdateAsync(id, input);
        }
      
        [HttpDelete]
        [Route("removeuserinorganizations")]
        public virtual Task<bool> RemoveFromOrganizationUnitAsync(UseToOrganizationUnitDeleteDto input)
        {
            return UserAppService.RemoveFromOrganizationUnitAsync(input);
        }
        [Authorize(BasicIdentityPermissions.Users.LoclUnLock)]
        [HttpPut]
        [Route("unlockuser/{id}")]
        public Task<bool> UpdateUseLockAsync(Guid id)
        {
            return UserAppService.UpdateUseLockAsync(id);
        }
        [Authorize]
        [HttpGet]
        [Route("allusers")]
        public Task<List<IdentityUserDto>> GetListAllAsync()
        {
            return UserAppService.GetListAllAsync();
        }
    }
}
