using King.AbpVnextPro.Dictionary.DataDictionarys.Dto;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;
using Volo.Abp;
using King.AbpVnextPro.Dictionary.Permissions;
using King.AbpVnextPro.Dictionary.Localization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.ObjectMapping;

namespace King.AbpVnextPro.Dictionary.DataDictionarys
{
   
    public class DictionaryDetailAppService :
       CrudAppService<DataDictionaryDetail, DictionaryDetailDto, Guid, GetDictionaryDetailInputDto,
           CreateDataDictionaryDetailDto, UpdateDataDictionaryDetailDto>, IDictionaryDetailAppService
    {
        protected IRepository<DataDictionary, Guid> MasterRepository { get; }

        public DictionaryDetailAppService(IRepository<DataDictionaryDetail, Guid> repository,
            IRepository<DataDictionary, Guid> masterRepository) : base(repository)
        {
            MasterRepository = masterRepository;
            LocalizationResource = typeof(DictionaryResource);
        }

        [Authorize(DictionaryPermissions.DataDictionaryDetail.Create)]
        public override async Task<DictionaryDetailDto> CreateAsync(CreateDataDictionaryDetailDto input)
        {
            var master = await MasterRepository.FindAsync(d => d.Id == input.DataDictionaryId);
            if (master == null)
            {
                throw new UserFriendlyException(message: L["DetailCreateMasterNullMessage"],
                    DictionaryErrorCodes.DictionaryIsNotExist);
            }

            var exist = await Repository.FindAsync(d => d.Label == input.Label);
            if (exist != null)
            {
                throw new UserFriendlyException(message: L["HasCreatedMessage", input.Label],
                    DictionaryErrorCodes.DictionaryDetailsIsExist);
            }

            var result = await Repository.InsertAsync(new DataDictionaryDetail(
                GuidGenerator.Create(),
                input.DataDictionaryId,
                CurrentTenant.Id,
                input.Label,
                input.Value,
                input.Sort)
            );
            return ObjectMapper.Map<DataDictionaryDetail, DictionaryDetailDto>(result);
        }

        [Authorize(DictionaryPermissions.DataDictionaryDetail.Update)]
        public override async Task<DictionaryDetailDto> UpdateAsync(Guid id, UpdateDataDictionaryDetailDto input)
        {
            var detail = await Repository.GetAsync(id);
            detail.Label = input.Label;
            detail.Value = input.Value;
            detail.Sort = input.Sort;
            var result = await Repository.UpdateAsync(detail, true);
            return ObjectMapper.Map<DataDictionaryDetail, DictionaryDetailDto>(result);
        }

        [Authorize(DictionaryPermissions.DataDictionaryDetail.Delete)]
        public virtual async Task DeleteAsync(BatchDeleteDictionaryDto input)
        {
            foreach (var id in input.Ids)
            {
                await Repository.DeleteAsync(id);
            }
        }
      
        public virtual async Task<PagedResultDto<DictionaryDetailDto>> GetDetailListByDictionaryId(GetDictionaryDetailByDtIdDto input)
        {
            var list = (await Repository.GetQueryableAsync()).Where(x => x.DataDictionaryId == input.DictionaryId).PageBy(input.SkipCount,input.MaxResultCount).ToList();
            var count = (await Repository.GetQueryableAsync()).Where(x => x.DataDictionaryId == input.DictionaryId).Count();
            return  new PagedResultDto<DictionaryDetailDto>(count, ObjectMapper.Map<List<DataDictionaryDetail>, List<DictionaryDetailDto>>(list));
        }
    }
}
