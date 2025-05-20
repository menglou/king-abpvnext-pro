using King.AbpVnextPro.Dictionary.DataDictionarys.Dto;
using King.AbpVnextPro.Dictionary.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.Dictionary.DataDictionarys
{
    [Authorize]
    [RemoteService(Name = "DictionaryDetail")]
    [ControllerName("DictionaryDetail")]
    [Area("DictionaryDetail")]
    [Route("/api/data-dictionary-detail/dictionary-detail")]
    public class DictionaryDetailController : DictionaryController, IDictionaryDetailAppService
    {
        protected IDictionaryDetailAppService _dictionaryDetailAppService { get; set; }

        public DictionaryDetailController(IDictionaryDetailAppService dictionaryDetailAppService)
        {
            _dictionaryDetailAppService = dictionaryDetailAppService;
        }
        [HttpPost]
        [Authorize(DictionaryPermissions.DataDictionaryDetail.Create)]
        public virtual Task<DictionaryDetailDto> CreateAsync(CreateDataDictionaryDetailDto input)
        {
            return _dictionaryDetailAppService.CreateAsync(input);
        }

        [HttpDelete]
        [Route("batchdelete")]
        public virtual Task DeleteAsync(BatchDeleteDictionaryDto input)
        {
            return _dictionaryDetailAppService.DeleteAsync(input);
        }
        [HttpDelete]
        [Route("{id}")]
        [Authorize(DictionaryPermissions.DataDictionaryDetail.Delete)]
        public virtual Task DeleteAsync(Guid id)
        {
            return _dictionaryDetailAppService.DeleteAsync(id);
        }
        [HttpGet]
        [Route("{id}")]
        [Authorize(DictionaryPermissions.DataDictionaryDetail.Delete)]
        public virtual Task<DictionaryDetailDto> GetAsync(Guid id)
        {
            return _dictionaryDetailAppService.GetAsync(id);
        }
        [HttpGet]
        public virtual Task<PagedResultDto<DictionaryDetailDto>> GetListAsync(GetDictionaryDetailInputDto input)
        {
            return _dictionaryDetailAppService.GetListAsync(input);
        }
        [HttpPut]
        [Route("{id}")]
        [Authorize(DictionaryPermissions.DataDictionaryDetail.Update)]
        public virtual Task<DictionaryDetailDto> UpdateAsync(Guid id, UpdateDataDictionaryDetailDto input)
        {
            return _dictionaryDetailAppService.UpdateAsync(id, input);
        }
        [HttpGet]
        [Route("getDetailListBydtId")]
        public virtual Task<PagedResultDto<DictionaryDetailDto>> GetDetailListByDictionaryId(GetDictionaryDetailByDtIdDto input)
        {
            return _dictionaryDetailAppService.GetDetailListByDictionaryId(input);
        }

        [HttpGet]
        [Route("getdicdetailbydicname/{dicName}")]
        public virtual Task<List<DictionaryDetailDto>> GetDictionartDetailByDicNameAsync(string dicName)
        {
            return _dictionaryDetailAppService.GetDictionartDetailByDicNameAsync(dicName);
        }
    }
}
