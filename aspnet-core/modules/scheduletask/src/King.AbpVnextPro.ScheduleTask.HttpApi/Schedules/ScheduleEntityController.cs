using King.AbpVnextPro.ScheduleTask.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.ScheduleTask.Schedules
{
    [Authorize]
    [RemoteService(Name = "ScheduleTask")]
    [ControllerName("ScheduleTask")]
    [Area("ScheduleTask")]
    [Route("/api/schedule-task/schedule")]
    public class ScheduleEntityController : ScheduleTaskController, IScheduleEntityAppService
    {
        protected IScheduleEntityAppService _scheduleEntityAppService { get; set; }
        public ScheduleEntityController(IScheduleEntityAppService scheduleEntityAppService)
        {
            _scheduleEntityAppService = scheduleEntityAppService;
        }
        [Authorize(ScheduleTaskPermissions.ScheduleTask.Create)]
        [HttpPost]
        public virtual  Task<bool> CreateAsync(CreateScheduleInfoDto task)
        {
            return  _scheduleEntityAppService.CreateAsync(task);
        }
        [Authorize(ScheduleTaskPermissions.ScheduleTask.Update)]
        [HttpPut]
        public virtual Task<bool> UpdateAsync(UpdateScheduleInfoDto task)
        {
            return _scheduleEntityAppService.UpdateAsync(task);
        }
        [Authorize(ScheduleTaskPermissions.ScheduleTask.Delete)]
        [HttpDelete]
        [Route("{sid}")]
        public virtual Task<bool> DeleteAsync(Guid sid)
        {
            return  _scheduleEntityAppService.DeleteAsync(sid);
        }
       
        [HttpGet]
        [Route("{sid}")]
        public virtual Task<ScheduleEntityDto> GetAsync(Guid sid)
        {
            return  _scheduleEntityAppService.GetAsync(sid);
        }
        [Authorize(ScheduleTaskPermissions.ScheduleTask.Default)]
        [HttpGet]
        public virtual Task<PagedResultDto<ScheduleEntityDto>> GetListAsync(ScheduleTaskPagedListDto input)
        {
            return  _scheduleEntityAppService.GetListAsync(input);
        }
        [Authorize(ScheduleTaskPermissions.ScheduleTask.Pause)]
        [HttpGet]
        [Route("pause/{sid}")]
        public virtual Task<bool> PauseAsync(Guid sid)
        {
            return  _scheduleEntityAppService.PauseAsync(sid);
        }
        [Authorize(ScheduleTaskPermissions.ScheduleTask.Resume)]
        [HttpGet]
        [Route("resume/{sid}")]
        public virtual Task<bool> ResumeAsync(Guid sid)
        {
            return _scheduleEntityAppService.ResumeAsync(sid);
        }
        [Authorize(ScheduleTaskPermissions.ScheduleTask.RunOnce)]
        [HttpGet]
        [Route("runonce/{sid}")]
        public virtual Task<bool> RunOnceAsync(Guid sid)
        {
            return  _scheduleEntityAppService.RunOnceAsync(sid);
        }
        [Authorize(ScheduleTaskPermissions.ScheduleTask.Start)]
        [HttpGet]
        [Route("start/{sid}")]
        public virtual Task<bool> StartAsync(Guid sid)
        {
            return  _scheduleEntityAppService.StartAsync(sid);
        }
        [Authorize(ScheduleTaskPermissions.ScheduleTask.Stop)]
        [HttpGet]
        [Route("stop/{sid}")]
        public virtual Task<bool> StopAsync(Guid sid)
        {
            return  _scheduleEntityAppService.StopAsync(sid);
        }
        [HttpGet]
        [Route("all")]
        public virtual Task<List<ScheduleManagerDto>> GetListAllAsync(GetScheduleTaskListDto input)
        {
            return _scheduleEntityAppService.GetListAllAsync(input);
        }
        [HttpGet]
        [Route("log")]
        public virtual Task<PagedResultDto<ScheduleLogEntityDto>> GetScheduleLogListAsync(ScheduleLogPagedListDto input)
        {
            return _scheduleEntityAppService.GetScheduleLogListAsync(input);
        }
    }
}
