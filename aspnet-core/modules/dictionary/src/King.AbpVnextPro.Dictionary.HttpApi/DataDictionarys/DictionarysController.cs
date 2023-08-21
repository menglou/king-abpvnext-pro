using King.AbpVnextPro.Dictionary.DataDictionarys.Dto;
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
    [RemoteService(Name = "Dictionary")]
    [ControllerName("Dictionary")]
    [Area("Dictionary")]
    [Route("/api/data-dictionary/dictionary")]
    public class DictionarysController : DictionaryController, IDictionaryAppService
    {
        private IDictionaryAppService _dictionaryAppService { get; set; }
        public DictionarysController(IDictionaryAppService dictionaryAppService)
        {
            _dictionaryAppService = dictionaryAppService;
        }
        [HttpPost]
        public virtual  Task<DictionaryDto> CreateAsync(CreateDataDictionaryDto input)
        {
            return  _dictionaryAppService.CreateAsync(input);
        }
        [HttpDelete]
        [Route("batchelete")]
        public virtual Task DeleteAsync(BatchDeleteDictionaryDto input)
        {
            return  _dictionaryAppService.DeleteAsync(input);
        }
        [HttpDelete]
        [Route("{id}")]
        public virtual Task DeleteAsync(Guid id)
        {
            return  _dictionaryAppService.DeleteAsync(id);
        }
        [HttpGet]
        [Route("{id}")]
        public virtual Task<DictionaryDto> GetAsync(Guid id)
        {
            return  _dictionaryAppService.GetAsync(id);
        }
        [HttpGet]
        
        public virtual Task<PagedResultDto<DictionaryDto>> GetListAsync(GetDictionaryInputDto input)
        {
            return  _dictionaryAppService.GetListAsync(input);
        }
        [HttpPut]
        [Route("{id}")]
        public virtual Task<DictionaryDto> UpdateAsync(Guid id, UpdateDataDictionaryDto input)
        {
            return  _dictionaryAppService.UpdateAsync(id,input);
        }
    }
}
