using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.ScheduleTask.Schedules
{
    public class MessageModel:EntityDto
    {
        public string Message { get; set; }
        public bool IsSuccesss { get; set; }
    }
}
