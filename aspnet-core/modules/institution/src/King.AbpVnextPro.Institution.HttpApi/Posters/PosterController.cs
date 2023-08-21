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

namespace King.AbpVnextPro.Institution.Posters
{
    [Authorize]
    [RemoteService(Name = "Poster")]
    [Area("Poster")]
    [ControllerName("Poster")]
    [Route("api/posters/poster")]
    public class PosterController : InstitutionController, IPosterAppService
    {
        protected IPosterAppService PosterService { get; }
        public PosterController(IPosterAppService posterAppService)
        {
            PosterService = posterAppService;
        }

        [Authorize(Poster.Create)]
        [HttpPost]
        public virtual async Task<bool> CreateAsync(PosterCreationDto input)
        {
            return await PosterService.CreateAsync(input);
        }

        [Authorize(Poster.Delete)]
        [HttpDelete]
        [Route("{id}")]
        public virtual async Task<bool> DeleteAsync(Guid id)
        {
            return await PosterService.DeleteAsync(id);
        }
        [HttpGet]
        [Route("{id}")]
        public virtual async Task<PosterDto> GetAsync(Guid id)
        {
            return await PosterService.GetAsync(id);
        }
        [Authorize(Poster.Update)]
        [HttpPut]
        public virtual async Task<bool> UpdateAsync(PosterUpdateDto input)
        {
            return await PosterService.UpdateAsync(input);
        }
        [Authorize(Poster.Default)]
        [HttpGet]
        public virtual async Task<PagedResultDto<PosterDto>> GetListAsync(PosterPagedListDto input)
        {
            return await PosterService.GetListAsync(input);
        }
        [Authorize(Poster.BindUser)]
        [HttpPost]
        [Route("batch-bind-user-poster")]
        public virtual async Task<bool> BatchBindToPosterAsync(BatchUserPosterCreationDto input)
        {
            return await PosterService.BatchBindToPosterAsync(input);
        }

        [HttpGet]
        [Route("posterusers/{id}")]
        public virtual async Task<List<IdentityUserDto>> GetUserPosterAsync(Guid id)
        {
            return await PosterService.GetUserPosterAsync(id);
        }
    }
}
