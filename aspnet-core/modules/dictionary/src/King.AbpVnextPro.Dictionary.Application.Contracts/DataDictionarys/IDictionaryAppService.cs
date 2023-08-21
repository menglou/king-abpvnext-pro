using King.AbpVnextPro.Dictionary.DataDictionarys.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.Dictionary.DataDictionarys
{
    public interface IDictionaryAppService : ICrudAppService<DictionaryDto, Guid, GetDictionaryInputDto, CreateDataDictionaryDto, UpdateDataDictionaryDto>
    {
        Task DeleteAsync(BatchDeleteDictionaryDto input);
    }
}
