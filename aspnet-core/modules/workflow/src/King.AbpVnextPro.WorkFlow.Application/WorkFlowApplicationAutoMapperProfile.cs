using AutoMapper;
using AutoMapper.Internal.Mappers;
using King.AbpVnextPro.WorkFlow.Flows;
using King.AbpVnextPro.WorkFlow.Flows.DivisionSchemes;
using King.AbpVnextPro.WorkFlow.Flows.FlowDesigns;

namespace King.AbpVnextPro.WorkFlow;

public class WorkFlowApplicationAutoMapperProfile : Profile
{
    public WorkFlowApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
      
        CreateMap<FlowDesign, FlowDesignDto>();
        CreateMap<FlowInstanceModel, FlowNodeDto>();
        CreateMap<DivisionScheme, DivisionSchemeDto>();
    }
}
