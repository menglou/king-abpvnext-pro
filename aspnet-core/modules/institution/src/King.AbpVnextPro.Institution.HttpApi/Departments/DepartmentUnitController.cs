using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;
using static King.AbpVnextPro.Institution.Permissions.InstitutionPermissions;

namespace King.AbpVnextPro.Institution.Departments
{
    [Authorize]
    [RemoteService(Name = "DepartmentUnit")]
    [Area("DepartmentUnit")]
    [ControllerName("DepartmentUnit")]
    [Route("api/DepartmentUnits/departmentUnit")]
    public class DepartmentUnitController : InstitutionController, IDepartmentUnitAppService
    {
        protected IDepartmentUnitAppService UnitAppService { get; }
        public DepartmentUnitController(IDepartmentUnitAppService unitAppService)
        {
            UnitAppService = unitAppService;
        }
        [Authorize(DepartmentUnit.Create)]
        [HttpPost]
        public virtual Task<DepartmentUnitDto> CreateAsync(DepartmentUnitCreateDto input)
        {
            return UnitAppService.CreateAsync(input);
        }
        [Authorize(DepartmentUnit.Update)]
        [HttpPut]
        [Route("{id}")]
        public virtual Task<DepartmentUnitDto> UpdateAsync(Guid id, DepartmentUnitUpdateDto input)
        {
            return UnitAppService.UpdateAsync(id, input);
        }
        [Authorize(DepartmentUnit.Delete)]
        [HttpDelete]
        [Route("{id}")]
        public virtual Task DeleteAsync(Guid id)
        {
            return UnitAppService.DeleteAsync(id);
        }

        [HttpGet]
        [Route("all")]
        public virtual Task<ListResultDto<DepartmentUnitDto>> GetAllListAsync(GetAllDepartmentUnitInput input)
        {
            return UnitAppService.GetAllListAsync(input);
        }
        [HttpGet]
        [Route("{id}")]
        public virtual Task<DepartmentUnitDto> GetAsync(Guid id)
        {
            return UnitAppService.GetAsync(id);
        }
        [HttpGet]
        public virtual Task<PagedResultDto<DepartmentUnitDto>> GetListAsync(GetDepartmentUnitInput input)
        {
            return UnitAppService.GetListAsync(input);
        }

        [HttpPut]
        [Route("move")]
        public virtual Task MoveAsync(Guid id, Guid? parentId)
        {
            return UnitAppService.MoveAsync(id, parentId);
        }
        [HttpGet]
        [Route("{id}/details")]
        public virtual Task<DepartmentUnitDto> GetDetailsAsync(Guid id)
        {
            return UnitAppService.GetDetailsAsync(id);
        }
        [HttpGet]
        [Route("details")]
        public Task<PagedResultDto<DepartmentUnitDto>> GetListDetailsAsync(GetDepartmentUnitInput input)
        {
            return UnitAppService.GetListDetailsAsync(input);
        }

        [HttpGet]
        [Route("all/details")]
        public Task<ListResultDto<DepartmentUnitDto>> GetAllListDetailsAsync(GetAllDepartmentUnitInput input)
        {
            return UnitAppService.GetAllListDetailsAsync(input);
        }
        [HttpGet]
        [Route("children/{parentId}")]
        public Task<List<DepartmentUnitDto>> GetChildrenAsync(Guid parentId)
        {
            return UnitAppService.GetChildrenAsync(parentId);
        }
        [HttpGet]
        [Route("root")]
        public Task<ListResultDto<DepartmentUnitDto>> GetRootListAsync()
        {
            return UnitAppService.GetRootListAsync();
        }
        [HttpGet]
        [Route("next-code")]

        public Task<string> GetNextChildCodeAsync(Guid? parentId)
        {
            return UnitAppService.GetNextChildCodeAsync(parentId);
        }
        [Authorize(DepartmentUnit.Default)]
        [HttpGet]
        [Route("alldepartmentlist")]
        public Task<List<DepartmentUnitDto>> GetAllDepListAsync(GetAllDepartmentUnitInput input)
        {
            return UnitAppService.GetAllDepListAsync(input);
        }

        [HttpGet]
        [Route("users")]
        public Task<PagedResultDto<IdentityUserDto>> GetUsersAsync(Guid? ouId, GetIdentityUsersInputExtensionDto userInput)
        {
            return UnitAppService.GetUsersAsync(ouId, userInput);
        }
        [Authorize(DepartmentUnit.BindUser)]
        [HttpPost]
        [Route("batch-add-user-departmentunit")]
        public virtual Task<bool> BatchAddToDepartmentUnitsAsync(BatchUserDepartmentUnitCreationDto input)
        {
            return UnitAppService.BatchAddToDepartmentUnitsAsync(input);
        }

        [HttpGet]
        [Route("depusers/{id}")]
        public virtual Task<List<IdentityUserDto>> GetUsersDepAsync(Guid Id)
        {
            return UnitAppService.GetUsersDepAsync(Id);
        }
    }
}
