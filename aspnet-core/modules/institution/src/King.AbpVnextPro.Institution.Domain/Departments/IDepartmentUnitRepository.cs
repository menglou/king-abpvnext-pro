using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace King.AbpVnextPro.Institution.Departments
{
    public interface IDepartmentUnitRepository: IBasicRepository<DepartmentUnit, Guid>
    {
        Task<List<DepartmentUnit>> GetChildrenAsync(
           Guid? parentId,
           bool includeDetails = false,
           CancellationToken cancellationToken = default
        );

        Task<List<DepartmentUnit>> GetAllChildrenWithParentCodeAsync(
            string code,
            Guid? parentId,
            bool includeDetails = false,
            CancellationToken cancellationToken = default
        );

        Task<DepartmentUnit> GetAsync(
            string displayName,
            bool includeDetails = true,
            CancellationToken cancellationToken = default
        );

        Task<List<DepartmentUnit>> GetListAsync(
            string sorting = null,
            int maxResultCount = int.MaxValue,
            int skipCount = 0,
            bool includeDetails = false,
            CancellationToken cancellationToken = default
        );

        Task<List<DepartmentUnit>> GetListAsync(
            IEnumerable<Guid> ids,
            bool includeDetails = false,
            CancellationToken cancellationToken = default
        );

 
        Task<List<IdentityUser>> GetMembersAsync(
            DepartmentUnit departmentUnit,
            string sorting = null,
            int maxResultCount = int.MaxValue,
            int skipCount = 0,
            string filter = null,
            bool includeDetails = false,
            CancellationToken cancellationToken = default
        );

        Task<int> GetMembersCountAsync(
            DepartmentUnit departmentUnit,
            string filter = null,
            CancellationToken cancellationToken = default
        );

        Task<List<IdentityUser>> GetUnaddedUsersAsync(
            DepartmentUnit departmentUnit,
            string sorting = null,
            int maxResultCount = int.MaxValue,
            int skipCount = 0,
            string filter = null,
            bool includeDetails = false,
            CancellationToken cancellationToken = default
        );

        Task<int> GetUnaddedUsersCountAsync(
            DepartmentUnit departmentUnit,
            string filter = null,
            CancellationToken cancellationToken = default
        );

        Task RemoveAllMembersAsync(
            DepartmentUnit departmentUnit,
            CancellationToken cancellationToken = default
        );
    }
}
