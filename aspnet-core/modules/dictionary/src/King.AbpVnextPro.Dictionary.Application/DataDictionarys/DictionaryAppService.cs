using King.AbpVnextPro.Dictionary.DataDictionarys.Dto;
using King.AbpVnextPro.Dictionary.Localization;
using King.AbpVnextPro.Dictionary.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace King.AbpVnextPro.Dictionary.DataDictionarys
{
    public class DictionaryAppService : CrudAppService<DataDictionary, DictionaryDto, Guid, GetDictionaryInputDto, CreateDataDictionaryDto,
            UpdateDataDictionaryDto>, IDictionaryAppService
    {


        private readonly IRepository<DataDictionaryDetail, Guid> _dictionaryDetail;

        public DictionaryAppService(IRepository<DataDictionary, Guid> repository,
            IRepository<DataDictionaryDetail, Guid> dictionaryDetail) : base(repository)
        {
            _dictionaryDetail = dictionaryDetail;
            LocalizationResource = typeof(DictionaryResource);
        }

        [Authorize(DictionaryPermissions.DataDictionary.Create)]
        public override async Task<DictionaryDto> CreateAsync(CreateDataDictionaryDto input)
        {
            if ((await Repository.FindAsync(d => d.Name == input.Name)) != null)
            {
                throw new UserFriendlyException(L["HasCreatedMessage", input.Name],
                    DictionaryErrorCodes.DictionaryIsExist);
            }

            var dic = new DataDictionary(
                GuidGenerator.Create(),
                input.Name,
                input.Description,
                input.Sort,
                CurrentTenant.Id
            );
            var result = await Repository.InsertAsync(dic, true);
            return ObjectMapper.Map<DataDictionary, DictionaryDto>(result);
        }

        [Authorize(DictionaryPermissions.DataDictionary.Update)]
        public override async Task<DictionaryDto> UpdateAsync(Guid id, UpdateDataDictionaryDto input)
        {
            var dic = await Repository.GetAsync(id);
            dic.Name = input.Name;
            dic.Description = input.Description;
            dic.Sort = input.Sort;
            var result = await Repository.UpdateAsync(dic, true);
            return ObjectMapper.Map<DataDictionary, DictionaryDto>(result);
        }

        [Authorize(DictionaryPermissions.DataDictionary.Delete)]
        public virtual async Task DeleteAsync(BatchDeleteDictionaryDto input)
        {
            foreach (var id in input.Ids)
            {
                await DeleteAsync(id);
            }
        }

        [Authorize(DictionaryPermissions.DataDictionary.Delete)]
        public override async Task DeleteAsync(Guid id)
        {
            var detail = await Repository.GetAsync(id);
            if (detail == null)
            {
                return;
            }

            var details = (await _dictionaryDetail.GetListAsync())
                .Where(d => d.DataDictionaryId == id)
                .ToList();
            foreach (var d in details)
            {
                await _dictionaryDetail.DeleteAsync(d.Id);
            }

            await Repository.DeleteAsync(id);
        }
       
    }
}
