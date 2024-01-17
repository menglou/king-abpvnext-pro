using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.Openiddict.Logs.SecurityLogs
{
    public class AutoDeleteSecurityLogDto:EntityDto
    {
        /// <summary>
        /// 保留的日志的天数
        /// </summary>
        public int RetainDay { get; set; }
    }
}
