using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.IdentityServer.Logs.AuditLogging
{
    public class AutoDeleteAuditLogParamDto:EntityDto
    {
        /// <summary>
        /// 保留的日志的天数
        /// </summary>
        public int RetainDay { get; set; }
    }
}
