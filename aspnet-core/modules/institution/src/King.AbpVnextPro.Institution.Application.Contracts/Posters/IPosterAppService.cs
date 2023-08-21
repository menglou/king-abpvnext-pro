using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Identity;

namespace King.AbpVnextPro.Institution.Posters
{
    public interface IPosterAppService : IApplicationService
    {
        Task<bool> CreateAsync(PosterCreationDto input);
        Task<bool> DeleteAsync(Guid id);
        Task<PosterDto> GetAsync(Guid id);
        Task<bool> UpdateAsync(PosterUpdateDto input);
        Task<PagedResultDto<PosterDto>> GetListAsync(PosterPagedListDto input);
        Task<bool> BatchBindToPosterAsync(BatchUserPosterCreationDto input);
        /// <summary>
        /// 根据岗位Id获取用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<IdentityUserDto>> GetUserPosterAsync(Guid id);
    }
}
