using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.ObjectMapping;

namespace King.AbpVnextPro.Institution.Departments
{
    public class DepartmentUnitAppService:InstitutionAppService, IDepartmentUnitAppService
    {
        private DepartmentUnitManager UnitManager;
        private IDepartmentUnitRepository DepartmentUnitRepository; 
        protected IIdentityUserAppService UserAppService { get; }
        protected IIdentityUserRepository UserRepository { get; }
        private IUserDepartmentUnitRepository UserDepRepository; 
        public DepartmentUnitAppService(DepartmentUnitManager unitManager, IDepartmentUnitRepository departmentUnitRepository, IIdentityUserAppService userAppService, IIdentityUserRepository userRepository, IUserDepartmentUnitRepository userDepRepository)
        {
            UnitManager = unitManager;
            DepartmentUnitRepository = departmentUnitRepository;
            UserAppService = userAppService;
            UserRepository = userRepository;
            UserDepRepository = userDepRepository;
        }

        //根据id 获取组织详情
        public virtual async Task<DepartmentUnitDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<DepartmentUnit, DepartmentUnitDto>(
                await DepartmentUnitRepository.GetAsync(id)
            );
        }

        //根据某个父组织获取下面所有的子组织
        public virtual async Task<DepartmentUnitDto> GetDetailsAsync(Guid id)
        {
            var ou = await DepartmentUnitRepository.GetAsync(id);
            var ouDto = ObjectMapper.Map<DepartmentUnit, DepartmentUnitDto>(ou);
            await TraverseTreeAsync(ouDto, ouDto.Children);
            return ouDto;
        }

        //获取所有的根组织
        public virtual async Task<ListResultDto<DepartmentUnitDto>> GetRootListAsync()
        {
            //TODO:Consider submitting to ABP to get the ou root node PR
            var root = ObjectMapper.Map<List<DepartmentUnit>, List<DepartmentUnitDto>>(await DepartmentUnitRepository.GetChildrenAsync(null));
            await SetLeaf(root);
            return new PagedResultDto<DepartmentUnitDto>(
                root.Count,
                root
            );
        }

        //获取组织列表分页
        public virtual async Task<PagedResultDto<DepartmentUnitDto>> GetListAsync(GetDepartmentUnitInput input)
        {
            var count = await DepartmentUnitRepository.GetCountAsync();
            var list = await DepartmentUnitRepository.GetListAsync(input.Sorting, input.MaxResultCount, input.SkipCount);
            return new PagedResultDto<DepartmentUnitDto>(
                count,
                ObjectMapper.Map<List<DepartmentUnit>, List<DepartmentUnitDto>>(list)
            );
        }

        public virtual async Task<PagedResultDto<DepartmentUnitDto>> GetListDetailsAsync(GetDepartmentUnitInput input)
        {
            var count = await DepartmentUnitRepository.GetCountAsync();
            var list = await DepartmentUnitRepository.GetListAsync(input.Sorting, input.MaxResultCount, input.SkipCount);
            var listDto = ObjectMapper.Map<List<DepartmentUnit>, List<DepartmentUnitDto>>(list);
            foreach (var ouDto in listDto)
            {
                await TraverseTreeAsync(ouDto, ouDto.Children);
            }
            return new PagedResultDto<DepartmentUnitDto>(
                count,
                listDto
            );
        }

        public virtual async Task<ListResultDto<DepartmentUnitDto>> GetAllListAsync(GetAllDepartmentUnitInput input)
        {
            var root = await GetRootListAsync();
            foreach (var ouDto in root.Items)
            {
                await TraverseTreeAsync(ouDto, ouDto.Children);
            }
            return root;
        }

        public virtual async Task<ListResultDto<DepartmentUnitDto>> GetAllListDetailsAsync(GetAllDepartmentUnitInput input)
        {
            var root = await GetRootListAsync();
            foreach (var ouDto in root.Items)
            {
                await TraverseTreeAsync(ouDto, ouDto.Children);
            }
            return root;
        }

        public virtual Task<string> GetNextChildCodeAsync(Guid? parentId)
        {
            return UnitManager.GetNextChildCodeAsync(parentId);
        }

        /// <summary>
        /// 获取所有组织 不存在级联关系的
        /// </summary>
        /// <returns></returns>
        public async Task<List<DepartmentUnitDto>> GetAllDepListAsync(GetAllDepartmentUnitInput input)
        {
            var query = await DepartmentUnitRepository.GetListAsync(input.Sorting);
            var result = query.WhereIf(!input.Filter.IsNullOrWhiteSpace(),x => x.DisplayName == input.Filter).Where(x => x.IsDeleted == false).ToList();
            return ObjectMapper.Map<List<DepartmentUnit>, List<DepartmentUnitDto>>(result);
        }

        public virtual async Task<List<DepartmentUnitDto>> GetChildrenAsync(Guid parentId)
        {
            //TODO:How to set is a leaf node when lazy loading
            var list = ObjectMapper.Map<List<DepartmentUnit>, List<DepartmentUnitDto>>(await UnitManager.FindChildrenAsync(parentId));
            await SetLeaf(list);
            return list;
        }

        //[Authorize(BasicIdentityPermissions.OrganitaionUnits.Create)]
        public virtual async Task<DepartmentUnitDto> CreateAsync(DepartmentUnitCreateDto input)
        {
            var ou = new DepartmentUnit(
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

            return ObjectMapper.Map<DepartmentUnit, DepartmentUnitDto>(ou);
        }

        //[Authorize(BasicIdentityPermissions.OrganitaionUnits.Update)]
        public virtual async Task<DepartmentUnitDto> UpdateAsync(Guid id, DepartmentUnitUpdateDto input)
        {
            var ou = await DepartmentUnitRepository.GetAsync(id);
            ou.ConcurrencyStamp = input.ConcurrencyStamp;
            ou.DisplayName = input.DisplayName;

            input.MapExtraPropertiesTo(ou);

            await UnitManager.UpdateAsync(ou);
            await CurrentUnitOfWork.SaveChangesAsync();

            return ObjectMapper.Map<DepartmentUnit, DepartmentUnitDto>(ou);
        }

        //[Authorize(BasicIdentityPermissions.OrganitaionUnits.Delete)]
        public virtual async Task DeleteAsync(Guid id)
        {
            var ou = await DepartmentUnitRepository.GetAsync(id, false);
            if (ou == null)
            {
                return;
            }
            await UnitManager.DeleteAsync(id);
        }

        public virtual async Task MoveAsync(Guid id, Guid? parentId)
        {
            var ou = await DepartmentUnitRepository.GetAsync(id);
            if (ou == null)
            {
                return;
            }
            await UnitManager.MoveAsync(id, parentId);
        }

        //[Authorize(IdentityPermissions.Users.Default)]
        public virtual async Task<PagedResultDto<IdentityUserDto>> GetUsersAsync(Guid? ouId, GetIdentityUsersInputExtensionDto userInput)
        {
            if (!ouId.HasValue)
            {
                return await UserAppService.GetListAsync(userInput);
            }
            IEnumerable<IdentityUser> list = new List<IdentityUser>();
            var ou = await DepartmentUnitRepository.GetAsync(ouId.Value);
            if (userInput.includeChildren)
            {
                var selfAndChildren = await DepartmentUnitRepository.GetAllChildrenWithParentCodeAsync(ou.Code, ou.Id);
                selfAndChildren.Add(ou);
                //Consider submitting PR to get its own overloading method containing all the members of the child node
                foreach (var child in selfAndChildren)
                {
                    // Find child nodes where users have duplicates (users can have multiple organizations)
                    //count += await UnitRepository.GetMembersCountAsync(child, usersInput.Filter);
                    list = Enumerable.Union(list, await DepartmentUnitRepository.GetMembersAsync(
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

        /// <summary>
        /// 部门批量绑定用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public virtual async Task<bool> BatchAddToDepartmentUnitsAsync(BatchUserDepartmentUnitCreationDto input)
        {
            List<UserDepartmentUnit> userDepList = new List<UserDepartmentUnit>();
            //先删除该部门下所有绑定用户再新增
            var query = await UserDepRepository.GetListAsync();
            var list = query.Where(x => x.DepartmentUnitId == input.DepartmentUnitId).ToList();
            await UserDepRepository.DeleteManyAsync(list);

            foreach (var item in input.UserId)
            {
                UserDepartmentUnit userDep = new UserDepartmentUnit()
                {
                    UserId = item,
                    DepartmentUnitId = input.DepartmentUnitId,
                    TenantId = CurrentTenant.Id
                };
                userDepList.Add(userDep);
            }
            await UserDepRepository.InsertManyAsync(userDepList);
            return true;
        }

        /// <summary>
        /// 根据部门Id查询绑定的所有用户
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public virtual async Task<List<IdentityUserDto>> GetUsersDepAsync(Guid Id)
        {
            var list = from userdep in await UserDepRepository.GetListAsync()
                       join user in await UserRepository.GetListAsync()
                       on userdep.UserId equals user.Id
                       where userdep.DepartmentUnitId == Id
                       select new IdentityUserDto
                       {
                           Id = user.Id,
                           Name = user.Name,
                           UserName = user.UserName,
                       };
            return list.ToList();
        }

        /// <summary>
        /// 后面考虑处理存储leaf到数据库,避免这么进行处理
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        protected virtual async Task SetLeaf(List<DepartmentUnitDto> list)
        {
            foreach (var item in list)
            {
                if ((await DepartmentUnitRepository.GetChildrenAsync(item.Id)).Count == 0)
                {
                    item.SetLeaf();
                }
            }
        }

        protected virtual async Task TraverseTreeAsync(DepartmentUnitDto dto, List<DepartmentUnitDto> children)
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
