using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.ScheduleTask.Schedules
{
    public interface IScheduleEntityAppService:IApplicationService
    {
        Task<bool> CreateAsync(CreateScheduleInfoDto task);
        Task<bool> StartAsync(Guid sid);
        Task<bool> StopAsync(Guid sid);
        Task<bool> PauseAsync(Guid sid);
        Task<bool> ResumeAsync(Guid sid);
        Task<bool> DeleteAsync(Guid sid);
        Task<bool> RunOnceAsync(Guid sid);
        Task<PagedResultDto<ScheduleEntityDto>> GetListAsync(ScheduleTaskPagedListDto input);
        Task<ScheduleEntityDto> GetAsync(Guid sid);
        Task<bool> UpdateAsync(UpdateScheduleInfoDto input);
        Task<List<ScheduleManagerDto>> GetListAllAsync(GetScheduleTaskListDto input);
        Task<PagedResultDto<ScheduleLogEntityDto>> GetScheduleLogListAsync(ScheduleLogPagedListDto input);
    }
}
