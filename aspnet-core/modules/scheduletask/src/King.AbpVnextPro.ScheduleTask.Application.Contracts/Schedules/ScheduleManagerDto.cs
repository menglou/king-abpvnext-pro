using System;
using System.Collections.Generic;
using System.Text;

namespace King.AbpVnextPro.ScheduleTask.Schedules
{
    public class ScheduleManagerDto:CreateScheduleInfoDto
    {
        public Guid Id { get; set; }

        public Guid? CreatorId { get; set; }
    }
}
