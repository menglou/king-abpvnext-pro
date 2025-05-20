using King.AbpVnextPro.Institution.Localization;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Services;
using Volo.Abp.Identity;
using Volo.Abp.Threading;
using Volo.Abp.Uow;

namespace King.AbpVnextPro.Institution.Departments
{
    public class DepartmentUnitManager : DomainService
    {
        protected IDepartmentUnitRepository _departmentUnitRepository { get; }
        protected IStringLocalizer<InstitutionResource> Localizer { get; }
        protected ICancellationTokenProvider CancellationTokenProvider { get; }

        public DepartmentUnitManager(
           IDepartmentUnitRepository departmentUnitRepository,
           IStringLocalizer<InstitutionResource> localizer,
           ICancellationTokenProvider cancellationTokenProvider)
        {
            _departmentUnitRepository = departmentUnitRepository;
            Localizer = localizer;
            CancellationTokenProvider = cancellationTokenProvider;
        }

        [UnitOfWork]
        public virtual async Task CreateAsync(DepartmentUnit departmentUnit)
        {
            departmentUnit.Code = await GetNextChildCodeAsync(departmentUnit.ParentId);
            await ValidateOrganizationUnitAsync(departmentUnit);
            await _departmentUnitRepository.InsertAsync(departmentUnit);
        }

        public virtual async Task UpdateAsync(DepartmentUnit departmentUnit)
        {
            await ValidateOrganizationUnitAsync(departmentUnit);
            await _departmentUnitRepository.UpdateAsync(departmentUnit);
        }

        public virtual async Task<string> GetNextChildCodeAsync(Guid? parentId)
        {
            var lastChild = await GetLastChildOrNullAsync(parentId);
            if (lastChild != null)
            {
                return OrganizationUnit.CalculateNextCode(lastChild.Code);
            }

            var parentCode = parentId != null
                ? await GetCodeOrDefaultAsync(parentId.Value)
                : null;

            return OrganizationUnit.AppendCode(
                parentCode,
                OrganizationUnit.CreateCode(1)
            );
        }


        public virtual async Task<DepartmentUnit> GetLastChildOrNullAsync(Guid? parentId)
        {
            var children = await _departmentUnitRepository.GetChildrenAsync(parentId);
            return children.OrderBy(c => c.Code).LastOrDefault();
        }

        [UnitOfWork]
        public virtual async Task DeleteAsync(Guid id)
        {
            var children = await FindChildrenAsync(id, true);

            foreach (var child in children)
            {
                await _departmentUnitRepository.RemoveAllMembersAsync(child);
                await _departmentUnitRepository.DeleteAsync(child);
            }

            var organizationUnit = await _departmentUnitRepository.GetAsync(id);

            await _departmentUnitRepository.RemoveAllMembersAsync(organizationUnit);
            await _departmentUnitRepository.DeleteAsync(id);
        }

        [UnitOfWork]
        public virtual async Task MoveAsync(Guid id, Guid? parentId)
        {
            var organizationUnit = await _departmentUnitRepository.GetAsync(id);
            if (organizationUnit.ParentId == parentId)
            {
                return;
            }

            //Should find children before Code change
            var children = await FindChildrenAsync(id, true);

            //Store old code of OU
            var oldCode = organizationUnit.Code;

            //Move OU
            organizationUnit.Code = await GetNextChildCodeAsync(parentId);
            organizationUnit.ParentId = parentId;

            await ValidateOrganizationUnitAsync(organizationUnit);

            //Update Children Codes
            foreach (var child in children)
            {
                child.Code = OrganizationUnit.AppendCode(organizationUnit.Code, DepartmentUnit.GetRelativeCode(child.Code, oldCode));
                await _departmentUnitRepository.UpdateAsync(child);
            }

            await _departmentUnitRepository.UpdateAsync(organizationUnit);
        }

        public virtual async Task<string> GetCodeOrDefaultAsync(Guid id)
        {
            var ou = await _departmentUnitRepository.GetAsync(id);
            return ou?.Code;
        }

        protected virtual async Task ValidateOrganizationUnitAsync(DepartmentUnit departmentUnit)
        {
            var siblings = (await FindChildrenAsync(departmentUnit.ParentId))
                .Where(ou => ou.Id != departmentUnit.Id)
                .ToList();

            if (siblings.Any(ou => ou.DisplayName == departmentUnit.DisplayName))
            {
                throw new BusinessException(InstitutionErrorCodes.DuplicateOrganizationUnitDisplayName)
                    .WithData("0", departmentUnit.DisplayName);
            }
        }

        public virtual async Task<List<DepartmentUnit>> FindChildrenAsync(Guid? parentId, bool recursive = false)
        {
            if (!recursive)
            {
                return await _departmentUnitRepository.GetChildrenAsync(parentId, includeDetails: true);
            }

            if (!parentId.HasValue)
            {
                return await _departmentUnitRepository.GetListAsync(includeDetails: true);
            }

            var code = await GetCodeOrDefaultAsync(parentId.Value);

            return await _departmentUnitRepository.GetAllChildrenWithParentCodeAsync(code, parentId, includeDetails: true);
        }

        public virtual Task<bool> IsInOrganizationUnitAsync(IdentityUser user, DepartmentUnit ou)
        {
            return Task.FromResult(user.IsInOrganizationUnit(ou.Id));
        }

    }
}
