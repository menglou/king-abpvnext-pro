using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.ScheduleTask.Schedules
{
    public class ScheduleLogPagedListDto : PagedAndSortedResultRequestDto
    {
        public Guid ScheduleId { get; set; }
        /// <summary>
        /// 执行状态（0正常 1失败）
        /// </summary>
        public string Status { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

    }
}
