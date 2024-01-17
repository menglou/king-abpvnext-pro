using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.IdentityServer.Logs.AuditLogging
{
    public interface IAuditLogAppService : IReadOnlyAppService<AuditLogDto, Guid, GetAuditLogDto>, IDeleteAppService<Guid>
    {
        Task DeleteManyAsync(params Guid[] ids);
        Task<MessageModelDto> AutoDeleteAuditLogAsync(AutoDeleteAuditLogParamDto input);
    }
}
