using King.AbpVnextPro.Institution.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Dynamic.Core;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Identity;

namespace King.AbpVnextPro.Institution.Departments
{
    internal class EfCoreDepartmentUnitRepository : EfCoreRepository<IInstitutionDbContext, DepartmentUnit, Guid>,
        IDepartmentUnitRepository
    {
        private IIdentityUserRepository IdentityUserRepository;
        public EfCoreDepartmentUnitRepository(
        IDbContextProvider<IInstitutionDbContext> dbContextProvider, IIdentityUserRepository identityUserRepository)
        : base(dbContextProvider)
        {
            IdentityUserRepository = identityUserRepository;
        }
        public virtual async Task<List<DepartmentUnit>> GetChildrenAsync(Guid? parentId, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            return await (await GetDbSetAsync())
            .IncludeDetails(includeDetails)
            .Where(x => x.ParentId == parentId)
            .ToListAsync(GetCancellationToken(cancellationToken));
        }

        public virtual async Task<List<DepartmentUnit>> GetAllChildrenWithParentCodeAsync(string code, Guid? parentId, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            return await (await GetDbSetAsync())
            .IncludeDetails(includeDetails)
            .Where(ou => ou.Code.StartsWith(code) && ou.Id != parentId.Value)
            .ToListAsync(GetCancellationToken(cancellationToken));
        }

        public virtual async Task<List<DepartmentUnit>> GetListAsync(string sorting = null, int maxResultCount = int.MaxValue, int skipCount = 0, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            return await (await GetDbSetAsync())
            .IncludeDetails(includeDetails)
            .OrderBy(sorting.IsNullOrEmpty() ? nameof(DepartmentUnit.DisplayName) : sorting)
            .PageBy(skipCount, maxResultCount)
            .ToListAsync(GetCancellationToken(cancellationToken));
        }

        public virtual async Task<List<DepartmentUnit>> GetListAsync(IEnumerable<Guid> ids, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            return await (await GetDbSetAsync())
           .IncludeDetails(includeDetails)
           .Where(t => ids.Contains(t.Id))
           .ToListAsync(GetCancellationToken(cancellationToken)); throw new NotImplementedException();
        }

        public virtual async Task<DepartmentUnit> GetAsync(string displayName, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            return await (await GetDbSetAsync())
           .IncludeDetails(includeDetails)
           .OrderBy(x => x.Id)
           .FirstOrDefaultAsync(
               ou => ou.DisplayName == displayName,
               GetCancellationToken(cancellationToken)
           );
        }

        public virtual async Task<List<IdentityUser>> GetMembersAsync(DepartmentUnit departmentUnit, string sorting = null, int maxResultCount = int.MaxValue, int skipCount = 0, string filter = null, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            var query = await CreateGetMembersFilteredQueryAsync(departmentUnit, filter);

            return await query.IncludeDetails(includeDetails).OrderBy(sorting.IsNullOrEmpty() ? nameof(IdentityUser.UserName) : sorting)
                        .PageBy(skipCount, maxResultCount)
                        .ToListAsync(GetCancellationToken(cancellationToken));
        }

        public virtual async Task<int> GetMembersCountAsync(DepartmentUnit departmentUnit, string filter = null, CancellationToken cancellationToken = default)
        {
            var query = await CreateGetMembersFilteredQueryAsync(departmentUnit, filter);

            return await query.CountAsync(GetCancellationToken(cancellationToken));
        }

        public virtual async Task<List<IdentityUser>> GetUnaddedUsersAsync(DepartmentUnit departmentUnit, string sorting = null, int maxResultCount = int.MaxValue, int skipCount = 0, string filter = null, bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            var dbContext = await GetDbContextAsync();

            var userIdsInDepartmentUnit = dbContext.Set<UserDepartmentUnit>()
                .Where(uou => uou.DepartmentUnitId == departmentUnit.Id)
                .Select(uou => uou.UserId);

         

            var query =(await IdentityUserRepository.GetDbContextAsync()).Set<IdentityUser>()
                .Where(u => !userIdsInDepartmentUnit.Contains(u.Id));

            if (!filter.IsNullOrWhiteSpace())
            {
                query = query.Where(u =>
                    u.UserName.Contains(filter) ||
                    u.Email.Contains(filter) ||
                    (u.PhoneNumber != null && u.PhoneNumber.Contains(filter))
                );
            }

            return await query
                .IncludeDetails(includeDetails)
                .OrderBy(sorting.IsNullOrEmpty() ? nameof(IdentityUser.Name) : sorting)
                .PageBy(skipCount, maxResultCount)
                .ToListAsync(GetCancellationToken(cancellationToken));
        }

        public virtual async Task<int> GetUnaddedUsersCountAsync(DepartmentUnit departmentUnit, string filter = null, CancellationToken cancellationToken = default)
        {
            var dbContext = await GetDbContextAsync();

            var userIdsInDepartmentUnit = dbContext.Set<UserDepartmentUnit>()
                .Where(uou => uou.DepartmentUnitId == departmentUnit.Id)
                .Select(uou => uou.UserId);

            return await (await IdentityUserRepository.GetDbContextAsync()).Set<IdentityUser>()
                .Where(u => !userIdsInDepartmentUnit.Contains(u.Id))
                .WhereIf(!filter.IsNullOrWhiteSpace(), u =>
                    u.UserName.Contains(filter) ||
                    u.Email.Contains(filter) ||
                    (u.PhoneNumber != null && u.PhoneNumber.Contains(filter)))
                .CountAsync(GetCancellationToken(cancellationToken));
        }

        public virtual async Task RemoveAllMembersAsync(DepartmentUnit departmentUnit, CancellationToken cancellationToken = default)
        {
            var dbContext = await GetDbContextAsync();

            var ouMembersQuery = await dbContext.Set<UserDepartmentUnit>()
                .Where(q => q.DepartmentUnitId == departmentUnit.Id)
                .ToListAsync(GetCancellationToken(cancellationToken));
            dbContext.Set<UserDepartmentUnit>().RemoveRange(ouMembersQuery);
        }

        protected virtual async Task<IQueryable<IdentityUser>> CreateGetMembersFilteredQueryAsync(DepartmentUnit departmentUnit, string filter = null)
        {
            var dbContext = await GetDbContextAsync();

            var query = from userOu in dbContext.Set<UserDepartmentUnit>()
                        join user in (await IdentityUserRepository.GetDbContextAsync()).Set<IdentityUser>() on userOu.UserId equals user.Id
                        where userOu.DepartmentUnitId == departmentUnit.Id
                        select user;

            if (!filter.IsNullOrWhiteSpace())
            {
                query = query.Where(u =>
                    u.UserName.Contains(filter) ||
                    u.Email.Contains(filter) ||
                    (u.PhoneNumber != null && u.PhoneNumber.Contains(filter))
                );
            }

            return query;
        }
    }
}
