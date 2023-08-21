using AutoMapper;
using King.AbpVnextPro.ScheduleTask.Schedules;

namespace King.AbpVnextPro.ScheduleTask;

public class ScheduleTaskApplicationAutoMapperProfile : Profile
{
    public ScheduleTaskApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    
        CreateMap<CreateScheduleInfoDto, ScheduleManagerDto>();
        CreateMap<ScheduleLogEntity, ScheduleLogEntityDto>();
    }
}
