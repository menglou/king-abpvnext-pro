using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.ScheduleTask.Schedules
{
    public class GetScheduleTaskListDto:EntityDto
    {
        public ScheduleStatus? ScheduleStatus { get; set; }

        public string JobName { get; set; }
    }
}
