using King.AbpVnextPro.Institution.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;
using Volo.Abp.Linq;
using Volo.Abp.Users;

namespace King.AbpVnextPro.Institution.Posters
{
    public class PosterAppService:InstitutionAppService, IPosterAppService
    {
        protected readonly IAsyncQueryableExecuter AsyncExecuter;
        protected readonly IPosterRepository PosterRepository;
        protected readonly IUserPosterRepository UserPosterRepository;
        protected IIdentityUserRepository UserRepository { get; }

        public PosterAppService(IPosterRepository posterRepository, IAsyncQueryableExecuter asyncExecuter,IUserPosterRepository userPosterRepository, IIdentityUserRepository userRepository)
        {
            PosterRepository = posterRepository;
            AsyncExecuter = asyncExecuter;
            UserPosterRepository = userPosterRepository;
            UserRepository = userRepository;
        }

        /// <summary>
        /// 新增岗位信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public virtual async Task<bool> CreateAsync(PosterCreationDto input)
        {
            Poster posterdto = new Poster(GuidGenerator.Create(), input.Name, input.Code, input.Sotr,input.Status,CurrentTenant.Id);
            var count = (from poster in await PosterRepository.GetListAsync()
                         where poster.Code == input.Code
                         select poster.Code).Count();
            if (count > 0)
            {
                throw new UserFriendlyException("岗位编码不可重复！");
            }
            await PosterRepository.InsertAsync(posterdto);
            return true;
        }
        /// <summary>
        /// 删除岗位信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<bool> DeleteAsync(Guid id)
        {
            var poster = await PosterRepository.GetAsync(id);
            if (poster == null)
            {
                throw new UserFriendlyException("要删除的岗位不存在，无法删除！");
            }
            await PosterRepository.DeleteAsync(poster);

            return true;
        }
        public virtual async Task<PosterDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<Poster, PosterDto>(
                await PosterRepository.GetAsync(id)
            );
        }

        public virtual async Task<bool> UpdateAsync(PosterUpdateDto input)
        {
            var poster = await PosterRepository.GetAsync(input.Id);
            if (poster != null)
            {
                poster.Name = input.Name;
                poster.Code = input.Code;
                poster.Sotr = input.Sotr;
                poster.Status = input.Status;
                poster.TenantId = CurrentTenant.Id;
                await PosterRepository.UpdateAsync(poster);
            }
            return true;
        }

        /// <summary>
        /// 分页查询岗位信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public virtual async Task<PagedResultDto<PosterDto>> GetListAsync(PosterPagedListDto input)
        {
            var query = from poster in await PosterRepository.GetListAsync()
                        select new PosterDto
                        {
                            Id = poster.Id,
                            Name = poster.Name,
                            Code = poster.Code,
                            Sotr = poster.Sotr,
                            Status = poster.Status,
                            TenantId = poster?.TenantId,
                            CreationTime = poster.CreationTime,
                        };

            var count = await AsyncExecuter.CountAsync(query.WhereIf(!input.Code.IsNullOrWhiteSpace(), x => x.Code.ToLower().Contains(input.Code.ToLower())).WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.ToLower().Contains(input.Name.ToLower())).WhereIf(input.Status != null, x => x.Status == input.Status).AsQueryable());

            var list = await AsyncExecuter.ToListAsync(query.WhereIf(!input.Code.IsNullOrWhiteSpace(), x => x.Code.ToLower().Contains(input.Code.ToLower())).WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.ToLower().Contains(input.Name.ToLower())).WhereIf(input.Status != null, x => x.Status == input.Status).AsQueryable().PageBy(input.SkipCount, input.MaxResultCount));

            return new PagedResultDto<PosterDto>(count, list);
        }

        /// <summary>
        /// 岗位批量绑定用户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public virtual async Task<bool> BatchBindToPosterAsync(BatchUserPosterCreationDto input)
        {
            List<UserPoster> userPosterList = new List<UserPoster>();
            var query = await UserPosterRepository.GetListAsync();
            var list = query.Where(x => x.PotserId == input.PosterId).ToList();
            //先删除该岗位绑定的所有用户再新增
            await UserPosterRepository.DeleteManyAsync(list);
            foreach(var item in input.UserId)
            {
                UserPoster userPoster = new UserPoster()
                {
                    UserId = item,
                    PotserId = input.PosterId,
                    TenantId = CurrentTenant.Id
                };
                userPosterList.Add(userPoster);
            }
            await UserPosterRepository.InsertManyAsync(userPosterList);
            return true;
        }

        /// <summary>
        /// 根据岗位Id查询该岗位绑定的所有用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual async Task<List<IdentityUserDto>> GetUserPosterAsync(Guid id)
        {
            var list = from userposter in await UserPosterRepository.GetListAsync()
                       join user in await UserRepository.GetListAsync()
                       on userposter.UserId equals user.Id
                       where userposter.PotserId == id
                       select new IdentityUserDto
                       {
                           Id = user.Id,
                           Name = user.Name,
                           UserName = user.UserName,
                       };
            return list.ToList();
        }

    }
}
