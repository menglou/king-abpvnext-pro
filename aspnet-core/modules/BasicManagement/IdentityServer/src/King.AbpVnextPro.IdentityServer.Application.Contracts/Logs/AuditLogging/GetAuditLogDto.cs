﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.IdentityServer.Logs.AuditLogging
{
    public class GetAuditLogDto : PagedAndSortedResultRequestDto
    {
        public GetAuditLogDto()
        {
        }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string HttpMethod { get; set; }
        public string Url { get; set; }
        public string UserName { get; set; }
        public string ApplicationName { get; set; }
        public string CorrelationId { get; set; }
        public int? MaxExecutionDuration { get; set; }
        public int? MinExecutionDuration { get; set; }
        public bool? HasException { get; set; }
        public HttpStatusCode? HttpStatusCode { get; set; }
        public bool IncludeDetails { get; set; }
    }
}
