
using King.AbpVnextPro.IdentityServer.Logs.AuditLogging;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace King.AbpVnextPro.IdentityServer.Logs
{
    [RemoteService(Name = AuditLogRemoteServiceConsts.RemoteServiceName)]
    [ControllerName("AuditLogging")]
    [Area("auditlogging")]
    [Route("/api/audit-logging/audit-logs")]
    public class AuditLogController : IdentityServerController, IAuditLogAppService
    {
        protected IAuditLogAppService AuditLogAppService { get; }
        public AuditLogController(IAuditLogAppService auditLogAppService)
        {
            AuditLogAppService = auditLogAppService;
        }

        [HttpDelete]
        [Route("{id}")]
        public virtual Task DeleteAsync(Guid id)
        {
            return AuditLogAppService.DeleteAsync(id);
        }

        [HttpDelete]
        [Route("delete-many")]
        public virtual Task DeleteManyAsync(Guid[] ids)
        {
            return AuditLogAppService.DeleteManyAsync(ids);
        }

        [HttpGet]
        [Route("{id}")]
        public virtual Task<AuditLogDto> GetAsync(Guid id)
        {
            return AuditLogAppService.GetAsync(id);
        }

        [HttpGet]
        public virtual Task<PagedResultDto<AuditLogDto>> GetListAsync(GetAuditLogDto input)
        {
            return AuditLogAppService.GetListAsync(input);
        }

        [HttpPost]
        public virtual Task<MessageModelDto> AutoDeleteAuditLogAsync(AutoDeleteAuditLogParamDto input)
        {
            return AuditLogAppService.AutoDeleteAuditLogAsync(input);
        }
    }
}
