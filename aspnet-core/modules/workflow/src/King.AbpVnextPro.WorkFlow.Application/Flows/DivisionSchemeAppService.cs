using King.AbpVnextPro.WorkFlow.Flows.DivisionSchemes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace King.AbpVnextPro.WorkFlow.Flows
{
    public class DivisionSchemeAppService : WorkFlowAppService
    {
        private IDivisionSchemeRepository _divisionSchemeRepository;
        public DivisionSchemeAppService(IDivisionSchemeRepository divisionSchemeRepository)
        {
            _divisionSchemeRepository = divisionSchemeRepository;
        }

        public async Task<List<DivisionSchemeDto>> GetAllListAsync()
        {
            var list = await _divisionSchemeRepository.GetListAsync();

            return ObjectMapper.Map<List<DivisionScheme>, List<DivisionSchemeDto>>(list);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var res = await _divisionSchemeRepository.FindAsync(x => x.Id == id);
            await _divisionSchemeRepository.DeleteAsync(res);
            return true;
        }

        public async Task<bool> UpdateAsync(Guid id, DivisionSchemeUpdateDto input)
        {
            var res = await _divisionSchemeRepository.FindAsync(x => x.Id == id);
            if (res != null)
            {
                res.Name= input.Name;
                res.Condition= input.Condition;
            }
            else
            {
                throw new UserFriendlyException(L["DivisionScheme:NoHave"]);
            }
            await _divisionSchemeRepository.UpdateAsync(res);
            return true;
        }

        public async Task<bool> CreateAsync(DivisionSchemeCreationDto input)
        {
            DivisionScheme divisionScheme=new DivisionScheme(input.Name,string.Empty,input.Condition,CurrentTenant.Id);
            await _divisionSchemeRepository.InsertAsync(divisionScheme);
            return true;
        }
    }
}
