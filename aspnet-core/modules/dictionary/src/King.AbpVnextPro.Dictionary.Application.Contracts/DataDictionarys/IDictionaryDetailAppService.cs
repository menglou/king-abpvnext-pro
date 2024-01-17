using King.AbpVnextPro.Dictionary.DataDictionarys.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.Dictionary.DataDictionarys
{
    public interface IDictionaryDetailAppService : ICrudAppService<DictionaryDetailDto, Guid, GetDictionaryDetailInputDto, CreateDataDictionaryDetailDto, UpdateDataDictionaryDetailDto>
    {
        Task DeleteAsync(BatchDeleteDictionaryDto input);
        Task<PagedResultDto<DictionaryDetailDto>> GetDetailListByDictionaryId(GetDictionaryDetailByDtIdDto input);
        Task<List<DictionaryDetailDto>> GetDictionartDetailByDicNameAsync(string dicName);
    }
}
