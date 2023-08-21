using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.ScheduleTask.Schedules
{
    public class ScheduleTaskPagedListDto: PagedAndSortedResultRequestDto
    {
        public string JobName { get; set; }
    }
}
