using King.AbpVnextPro.WorkFlow.Flows.FlowInstances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Uow;

namespace King.AbpVnextPro.WorkFlow.Flows
{
    /// <summary>
    /// 流程实例
    /// </summary>
    public class FlowInstanceAppService : WorkFlowAppService
    {
        private IFlowDesignRepository _flowDesignRepository;
        private IFlowInstanceRepository _flowInstanceRepository;
        public FlowInstanceAppService(IFlowInstanceRepository flowInstanceRepository, IFlowDesignRepository flowDesignRepository)
        {
            _flowDesignRepository = flowDesignRepository;
            _flowInstanceRepository = flowInstanceRepository;
        }


        public async Task CreateAsync(FlowInstanceCreationDto input)
        {
            var fdesigin = await _flowDesignRepository.FindAsync(x => x.Id == input.DesignId);
            if (fdesigin == null)
            {
                throw new UserFriendlyException(L["FlowDesinName:NoHave"]);
            }

            input.DesignContent = fdesigin.DesignContent;
            input.FormContent = fdesigin.FormContent;

            var flowInstance = ObjectMapper.Map<FlowInstanceCreationDto, FlowInstance>(input);

            flowInstance.DesignName = fdesigin.Name;
            flowInstance.Status = input.InstanceResult == 0 ? 1 : 2;

            if (input.InstanceResult == 1)
            { //提交为草稿时  不添加单据 InstanceResult=0 为草稿


                #region 流程操作记录
                FlowOperationHistory processOperationHistoryEntity = new FlowOperationHistory
                {
                    InstanceId = flowInstance.Id,
                    OperationType = OperationType.Apply,
                    NodeType = 0,
                    NodeId = "sid-start-node",
                    NodeName = "发起流程",
                    IsNewOperationt = true,
                    Content = "【发起】"
                             + 
                              CurrentUser.UserName
                             + "发起了一个流程【"
                             + input.CustomName + "】"
                };
                #endregion
            }
        }
    }
}
