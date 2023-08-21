using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using static King.AbpVnextPro.Openiddict.Permissions.OpeniddictPermissions;

namespace King.AbpVnextPro.Openiddict.Volo.Identity
{
    [RemoteService(false)]
    [Authorize(BasicIdentityPermissions.OrganitaionUnits.Default)]
    public class OrganizationUnitAppService: IdentityAppServiceBase, IOrganizationUnitAppService
    {
        protected OrganizationUnitManager UnitManager { get; }
        protected IOrganizationUnitRepository UnitRepository { get; }
        protected IIdentityUserAppService UserAppService { get; }
        protected IIdentityRoleAppService RoleAppService { get; }
        protected IIdentityUserRepository UserRepository { get; }
        public OrganizationUnitAppService(OrganizationUnitManager unitManager,IOrganizationUnitRepository unitRepository,IIdentityUserAppService userAppService,IIdentityRoleAppService roleAppService, IIdentityUserRepository userRepository)
        {
            UnitManager = unitManager;
            UnitRepository = unitRepository;
            UserAppService = userAppService;
            RoleAppService = roleAppService;
            UserRepository = userRepository;
        }
        //根据id 获取组织详情
        public virtual async Task<OrganizationUnitDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<OrganizationUnit, OrganizationUnitDto>(
                await UnitRepository.GetAsync(id)
            );
        }

        //根据某个父组织获取下面所有的子组织
        public virtual async Task<OrganizationUnitDto> GetDetailsAsync(Guid id)
        {
            var ou = await UnitRepository.GetAsync(id);
            var ouDto = ObjectMapper.Map<OrganizationUnit, OrganizationUnitDto>(ou);
            await TraverseTreeAsync(ouDto, ouDto.Children);
            return ouDto;
        }

        //获取所有的根组织
        public virtual async Task<ListResultDto<OrganizationUnitDto>> GetRootListAsync()
        {
            //TODO:Consider submitting to ABP to get the ou root node PR
            var root = ObjectMapper.Map<List<OrganizationUnit>, List<OrganizationUnitDto>>(await UnitRepository.GetChildrenAsync(null));
            await SetLeaf(root);
            return new PagedResultDto<OrganizationUnitDto>(
                root.Count,
                root
            );
        }

        //获取组织列表分页
        public virtual async Task<PagedResultDto<OrganizationUnitDto>> GetListAsync(GetOrganizationUnitInput input)
        {
            var count = await UnitRepository.GetCountAsync();
            var list = await UnitRepository.GetListAsync(input.Sorting, input.MaxResultCount, input.SkipCount);
            return new PagedResultDto<OrganizationUnitDto>(
                count,
                ObjectMapper.Map<List<OrganizationUnit>, List<OrganizationUnitDto>>(list)
            );
        }

        public virtual async Task<PagedResultDto<OrganizationUnitDto>> GetListDetailsAsync(GetOrganizationUnitInput input)
        {
            var count = await UnitRepository.GetCountAsync();
            var list = await UnitRepository.GetListAsync(input.Sorting, input.MaxResultCount, input.SkipCount);
            var listDto = ObjectMapper.Map<List<OrganizationUnit>, List<OrganizationUnitDto>>(list);
            foreach (var ouDto in listDto)
            {
                await TraverseTreeAsync(ouDto, ouDto.Children);
            }
            return new PagedResultDto<OrganizationUnitDto>(
                count,
                listDto
            );
        }

        public virtual async Task<ListResultDto<OrganizationUnitDto>> GetAllListAsync(GetAllOrgnizationUnitInput input)
        {
            var root = await GetRootListAsync();
            foreach (var ouDto in root.Items)
            {
                await TraverseTreeAsync(ouDto, ouDto.Children);
            }
            return root;
        }

        public virtual async Task<ListResultDto<OrganizationUnitDto>> GetAllListDetailsAsync(GetAllOrgnizationUnitInput input)
        {
            var root = await GetRootListAsync();
            foreach (var ouDto in root.Items)
            {
                await TraverseTreeAsync(ouDto, ouDto.Children);
            }
            return root;
        }

        public Task<string> GetNextChildCodeAsync(Guid? parentId)
        {
            return UnitManager.GetNextChildCodeAsync(parentId);
        }

        /// <summary>
        /// 获取所有组织 不存在级联关系的
        /// </summary>
        /// <returns></returns>
        public async Task<List<OrganizationUnitDto>> GetAllListAsync()
        {
            var query = await UnitRepository.GetListAsync();
            var result = query.Where(x => x.IsDeleted == false).ToList();
            return ObjectMapper.Map<List<OrganizationUnit>, List<OrganizationUnitDto>>(result);
        }

        public virtual async Task<List<OrganizationUnitDto>> GetChildrenAsync(Guid parentId)
        {
            //TODO:How to set is a leaf node when lazy loading
            var list = ObjectMapper.Map<List<OrganizationUnit>, List<OrganizationUnitDto>>(await UnitManager.FindChildrenAsync(parentId));
            await SetLeaf(list);
            return list;
        }

        [Authorize(BasicIdentityPermissions.OrganitaionUnits.Create)]
        public virtual async Task<OrganizationUnitDto> CreateAsync(OrganizationUnitCreateDto input)
        {
            var ou = new OrganizationUnit(
                GuidGenerator.Create(),
                input.DisplayName,
                input.ParentId,
                CurrentTenant.Id
            )
            {

            };
            input.MapExtraPropertiesTo(ou);

            await UnitManager.CreateAsync(ou);
            await CurrentUnitOfWork.SaveChangesAsync();

            return ObjectMapper.Map<OrganizationUnit, OrganizationUnitDto>(ou);
        }

        [Authorize(BasicIdentityPermissions.OrganitaionUnits.Update)]
        public virtual async Task<OrganizationUnitDto> UpdateAsync(Guid id, OrganizationUnitUpdateDto input)
        {
            var ou = await UnitRepository.GetAsync(id);
            ou.ConcurrencyStamp = input.ConcurrencyStamp;
            ou.DisplayName = input.DisplayName;

            input.MapExtraPropertiesTo(ou);

            await UnitManager.UpdateAsync(ou);
            await CurrentUnitOfWork.SaveChangesAsync();

            return ObjectMapper.Map<OrganizationUnit, OrganizationUnitDto>(ou);
        }

        [Authorize(BasicIdentityPermissions.OrganitaionUnits.Delete)]
        public virtual async Task DeleteAsync(Guid id)
        {
            var ou = await UnitRepository.GetAsync(id, false);
            if (ou == null)
            {
                return;
            }
            await UnitManager.DeleteAsync(id);
        }

        public async Task MoveAsync(Guid id, Guid? parentId)
        {
            var ou = await UnitRepository.GetAsync(id);
            if (ou == null)
            {
                return;
            }
            await UnitManager.MoveAsync(id, parentId);
        }

        [Authorize(IdentityPermissions.Users.Default)]
        public virtual async Task<PagedResultDto<IdentityUserDto>> GetUsersAsync(Guid? ouId, GetIdentityUsersInputExtensionDto userInput)
        {
            if (!ouId.HasValue)
            {
                return await UserAppService.GetListAsync(userInput);
            }
            IEnumerable<IdentityUser> list = new List<IdentityUser>();
            var ou = await UnitRepository.GetAsync(ouId.Value);
            if (userInput.includeChildren)
            {
                var selfAndChildren = await UnitRepository.GetAllChildrenWithParentCodeAsync(ou.Code, ou.Id);
                selfAndChildren.Add(ou);
                //Consider submitting PR to get its own overloading method containing all the members of the child node
                foreach (var child in selfAndChildren)
                {
                    // Find child nodes where users have duplicates (users can have multiple organizations)
                    //count += await UnitRepository.GetMembersCountAsync(child, usersInput.Filter);
                    list = Enumerable.Union(list, await UnitRepository.GetMembersAsync(
                           child,
                           userInput.Sorting,
                           //usersInput.MaxResultCount, // So let's think about looking up all the members of the subset
                           //usersInput.SkipCount,  
                           filter: userInput.Filter
                    ));
                }
            }
            else
            {
                list = await UserRepository
                   .GetUsersInOrganizationUnitAsync(ou.Id);
            }
            return new PagedResultDto<IdentityUserDto>(
                list.Count(),
                ObjectMapper.Map<List<IdentityUser>, List<IdentityUserDto>>(
                    list.Skip(userInput.SkipCount).Take(userInput.MaxResultCount)
                    .ToList()
                )
            );
        }

        [Authorize(IdentityPermissions.Roles.Default)]
        public virtual async Task<PagedResultDto<IdentityRoleDto>> GetRolesAsync(Guid? ouId, GetIdentityRolesInput roleInput)
        {
            if (!ouId.HasValue)
            {
                return await RoleAppService.GetListAsync(roleInput);
            }
            IEnumerable<IdentityRole> list = new List<IdentityRole>();
            var ou = await UnitRepository.GetAsync(ouId.Value);
            var selfAndChildren = await UnitRepository.GetAllChildrenWithParentCodeAsync(ou.Code, ou.Id);
            selfAndChildren.Add(ou);
            foreach (var child in selfAndChildren)
            {
                list = Enumerable.Union(list, await UnitRepository.GetRolesAsync(
                       child,
                       roleInput.Sorting
                ));
            }
            return new PagedResultDto<IdentityRoleDto>(
                list.Count(),
                ObjectMapper.Map<List<IdentityRole>, List<IdentityRoleDto>>(
                    list.Skip(roleInput.SkipCount).Take(roleInput.MaxResultCount)
                    .ToList()
                )
            );
        }

        /// <summary>
        /// 后面考虑处理存储leaf到数据库,避免这么进行处理
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        protected virtual async Task SetLeaf(List<OrganizationUnitDto> list)
        {
            foreach (var item in list)
            {
                if ((await UnitRepository.GetChildrenAsync(item.Id)).Count == 0)
                {
                    item.SetLeaf();
                }
            }
        }

        protected virtual async Task TraverseTreeAsync(OrganizationUnitDto dto, List<OrganizationUnitDto> children)
        {
            if (dto.Children.Count == 0)
            {
                children = await GetChildrenAsync(dto.Id);
                dto.Children.AddRange(children);
            }
            if (children == null || !children.Any())
            {
                await Task.CompletedTask;
                return;
            }
            foreach (var child in children)
            {
                var next = await GetChildrenAsync(child.Id);
                child.Children.AddRange(next);
                await TraverseTreeAsync(dto, child.Children);
            }
        }
    }
}
