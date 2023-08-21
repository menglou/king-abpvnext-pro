using King.AbpVnextPro.WorkFlow.Flows.FlowDesigns;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Linq;
using Volo.Abp.ObjectMapping;

namespace King.AbpVnextPro.WorkFlow.Flows
{
    public class FlowDesignAppService : WorkFlowAppService
    {
        private IAsyncQueryableExecuter _asyncExecuter;
        private IFlowDesignRepository _flowDesignRepository;
        public FlowDesignAppService(IFlowDesignRepository flowDesignRepository, IAsyncQueryableExecuter asyncExecuter)
        {
            _flowDesignRepository = flowDesignRepository;
            _asyncExecuter = asyncExecuter;
        }

        public async Task<bool> CreateAsync(FlowDesignCreationDto input)
        {
            var isexit = await _flowDesignRepository.FindAsync(x => x.Name == input.Name);
            if (isexit != null)
            {
                throw new UserFriendlyException(L["FlowDesinName:Have"]);
            }
            else
            {
                FlowNodeDto flowNodeDto = new FlowNodeDto();
                if (string.IsNullOrWhiteSpace(input.DesignContent))
                {
                    flowNodeDto = new FlowNodeDto();
                }
                var flowModel = JsonConvert.DeserializeObject<FlowInstanceModel>(input.DesignContent);//获取工作流模板内容的json对象;

                flowNodeDto = ObjectMapper.Map<FlowInstanceModel, FlowNodeDto>(flowModel);

                FlowDesign flowDesign = new FlowDesign(input.Name, input.DesignType, input.DesignContent, input.FormContent, input.PrintContent, input.Permission, JsonConvert.SerializeObject(flowNodeDto.ColnumPermissions), input.IsEnable, input.Remark, CurrentTenant.Id);

                await _flowDesignRepository.InsertAsync(flowDesign);
            }

            return true;
        }

        public async Task<bool> UpdateAsync(Guid id, FlowDesignUpdatedDto input)
        {
            var res=await _flowDesignRepository.FindAsync(x => x.Id == id);
            if(res != null)
            {
                throw new UserFriendlyException(L["FlowDesinName:NoHave"]);
            }
            else
            {
                var isexit = await _flowDesignRepository.FindAsync(x => x.Name == input.Name&&x.Id!= id);
                if (isexit != null)
                {
                    throw new UserFriendlyException(L["FlowDesinName:Have"]);
                }
                else
                {
                    FlowNodeDto flowNodeDto = new FlowNodeDto();
                    if (string.IsNullOrWhiteSpace(input.DesignContent))
                    {
                        flowNodeDto = new FlowNodeDto();
                    }
                    var flowModel = JsonConvert.DeserializeObject<FlowInstanceModel>(input.DesignContent);//获取工作流模板内容的json对象;

                    flowNodeDto = ObjectMapper.Map<FlowInstanceModel, FlowNodeDto>(flowModel);

                    res.DesignContent = input.DesignContent;
                    res.DesignType = input.DesignType;
                    res.Name = input.Name;
                    res.Permission = input.Permission;
                    res.PrintContent = input.PrintContent;
                    res.ColnumPermission = JsonConvert.SerializeObject(flowNodeDto.ColnumPermissions);
                    res.Remark= input.Remark;
                    res.IsEnable=input.IsEnable;
                    
                    await _flowDesignRepository.UpdateAsync(res);
                }
            }

            return true;
        }

        public async Task<bool>DeleteAsync(Guid id)
        {
            var res = await _flowDesignRepository.FindAsync(x => x.Id == id);
            if (res != null)
            {
                throw new UserFriendlyException(L["FlowDesinName:NoHave"]);
            }
            await _flowDesignRepository.DeleteAsync(res);
            return true;
        }

        public async Task<FlowDesignDto> GetAsync(Guid id)
        {
            var res = await _flowDesignRepository.FindAsync(x => x.Id == id);
            return ObjectMapper.Map<FlowDesign, FlowDesignDto>(res);
        }

        public async Task<PagedResultDto<FlowDesignDto>> GetListAsync(GetFlowDesignPageListDto input)
        {
            var count=await _asyncExecuter.CountAsync((await _flowDesignRepository.GetQueryableAsync()).WhereIf(!input.Name.IsNullOrWhiteSpace(),x=>x.Name.Contains(input.Name)).WhereIf(input.IsEnable.HasValue,x=>x.IsEnable==input.IsEnable.Value));

            var list= await _asyncExecuter.ToListAsync((await _flowDesignRepository.GetQueryableAsync()).WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Name)).WhereIf(input.IsEnable.HasValue, x => x.IsEnable == input.IsEnable.Value).PageBy(input.SkipCount,input.MaxResultCount));

            return new PagedResultDto<FlowDesignDto>(count, ObjectMapper.Map<List<FlowDesign>,List<FlowDesignDto>>(list)); 
        }
    }
}
