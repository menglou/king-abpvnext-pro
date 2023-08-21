﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Data;

namespace King.AbpVnextPro.Openiddict.Logs.AuditLogging
{
    public class AuditLogActionDto : EntityDto<Guid>, IHasExtraProperties
    {
        public string ServiceName { get; set; }
        public string MethodName { get; set; }
        public string Parameters { get; set; }
        public DateTime ExecutionTime { get; set; }
        public int ExecutionDuration { get; set; }
        public ExtraPropertyDictionary ExtraProperties { get; set; }

    }
}
