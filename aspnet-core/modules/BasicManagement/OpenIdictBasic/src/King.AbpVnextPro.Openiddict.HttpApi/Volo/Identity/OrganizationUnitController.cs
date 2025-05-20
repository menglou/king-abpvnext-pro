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

namespace King.AbpVnextPro.Openiddict.Volo.Identity
{
    [RemoteService(Name = IdentityRemoteServiceConsts.RemoteServiceName)]
    [Area("identity")]
    [ControllerName("Organization")]
    [Route("api/identity/organizations")]
    public class OrganizationUnitController : AbpController, IOrganizationUnitAppService
    {
        protected IOrganizationUnitAppService UnitAppService { get; }
        public OrganizationUnitController(IOrganizationUnitAppService unitAppService)
        {
            UnitAppService = unitAppService;
        }

        [HttpPost]
        public virtual Task<OrganizationUnitDto> CreateAsync(OrganizationUnitCreateDto input)
        {
            return UnitAppService.CreateAsync(input);
        }

        [HttpDelete]
        [Route("{id}")]
        public virtual Task DeleteAsync(Guid id)
        {
            return UnitAppService.DeleteAsync(id);
        }

        [HttpGet]
        [Route("all")]
        public virtual Task<ListResultDto<OrganizationUnitDto>> GetAllListAsync(GetAllOrgnizationUnitInput input)
        {
            return UnitAppService.GetAllListAsync(input);
        }

        [HttpGet]
        [Route("{id}")]
        public virtual Task<OrganizationUnitDto> GetAsync(Guid id)
        {
            return UnitAppService.GetAsync(id);
        }

        [HttpGet]
        public virtual Task<PagedResultDto<OrganizationUnitDto>> GetListAsync(GetOrganizationUnitInput input)
        {
            return UnitAppService.GetListAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public virtual Task<OrganizationUnitDto> UpdateAsync(Guid id, OrganizationUnitUpdateDto input)
        {
            return UnitAppService.UpdateAsync(id, input);
        }

        [HttpPut]
        [Route("move")]
        public virtual Task MoveAsync(Guid id, Guid? parentId)
        {
            return UnitAppService.MoveAsync(id, parentId);
        }

        [HttpGet]
        [Route("{id}/details")]
        public virtual Task<OrganizationUnitDto> GetDetailsAsync(Guid id)
        {
            return UnitAppService.GetDetailsAsync(id);
        }

        [HttpGet]
        [Route("details")]
        public virtual Task<PagedResultDto<OrganizationUnitDto>> GetListDetailsAsync(GetOrganizationUnitInput input)
        {
            return UnitAppService.GetListDetailsAsync(input);
        }

        [HttpGet]
        [Route("all/details")]
        public virtual Task<ListResultDto<OrganizationUnitDto>> GetAllListDetailsAsync(GetAllOrgnizationUnitInput input)
        {
            return UnitAppService.GetAllListDetailsAsync(input);
        }

        [HttpGet]
        [Route("children/{parentId}")]
        public virtual Task<List<OrganizationUnitDto>> GetChildrenAsync(Guid parentId)
        {
            return UnitAppService.GetChildrenAsync(parentId);
        }

        [HttpGet]
        [Route("root")]
        public virtual Task<ListResultDto<OrganizationUnitDto>> GetRootListAsync()
        {
            return UnitAppService.GetRootListAsync();
        }

        [HttpGet]
        [Route("next-code")]
        public virtual Task<string> GetNextChildCodeAsync(Guid? parentId)
        {
            return UnitAppService.GetNextChildCodeAsync(parentId);
        }
        [HttpGet]
        [Route("allorglist")]
        public Task<List<OrganizationUnitDto>> GetAllListAsync()
        {
            return UnitAppService.GetAllListAsync();
        }

        [HttpGet]
        [Route("users")]
        public virtual Task<PagedResultDto<IdentityUserDto>> GetUsersAsync(Guid? ouId, GetIdentityUsersInputExtensionDto usersInput)
        {
            return UnitAppService.GetUsersAsync(ouId, usersInput);
        }

        [HttpGet]
        [Route("roles")]
        public virtual Task<PagedResultDto<IdentityRoleDto>> GetRolesAsync(Guid? ouId, GetIdentityRolesInput roleInput)
        {
            return UnitAppService.GetRolesAsync(ouId, roleInput);
        }

        
    }
}
