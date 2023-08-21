using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Identity;

namespace King.AbpVnextPro.Institution.Departments
{
    public interface IDepartmentUnitAppService: ICrudAppService<DepartmentUnitDto, Guid, GetDepartmentUnitInput, DepartmentUnitCreateDto, DepartmentUnitUpdateDto>
    {
        Task<ListResultDto<DepartmentUnitDto>> GetRootListAsync();

        Task<DepartmentUnitDto> GetDetailsAsync(Guid id);

        Task<PagedResultDto<DepartmentUnitDto>> GetListDetailsAsync(GetDepartmentUnitInput input);

        Task<ListResultDto<DepartmentUnitDto>> GetAllListAsync(GetAllDepartmentUnitInput input);

        Task<ListResultDto<DepartmentUnitDto>> GetAllListDetailsAsync(GetAllDepartmentUnitInput input);

        Task<List<DepartmentUnitDto>> GetChildrenAsync(Guid parentId);

        Task<string> GetNextChildCodeAsync(Guid? parentId);
        Task<List<DepartmentUnitDto>> GetAllDepListAsync(GetAllDepartmentUnitInput input);
        Task MoveAsync(Guid id, Guid? parentId);

        Task<PagedResultDto<IdentityUserDto>> GetUsersAsync(Guid? ouId, GetIdentityUsersInputExtensionDto userInput);

        Task<bool> BatchAddToDepartmentUnitsAsync(BatchUserDepartmentUnitCreationDto input);
        Task<List<IdentityUserDto>> GetUsersDepAsync(Guid Id);

    }
}
