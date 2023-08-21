using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.Openiddict.Logs.SecurityLogs
{
    public class GetSecurityLogDto : PagedAndSortedResultRequestDto
    {
        public GetSecurityLogDto()
        {
        }
        public string ApplicationName { get; set; }

        public string Identity { get; set; }

        public string ActionName { get; set; }

        public string UserName { get; set; }

        public string ClientId { get; set; }

        public string CorrelationId { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }
    }
}
