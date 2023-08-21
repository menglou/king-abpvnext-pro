using King.AbpVnextPro.IdentityServer;
using King.AbpVnextPro.IdentityServer.Logs.SecurityLogs;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;
using static King.AbpVnextPro.IdentityServer.Permissions.IdentityServerPermissions;

namespace BaiscBaKing.AbpVnextPro.IdentityServerckEnd.Logs
{
    [RemoteService(false)]
    [Authorize(SecurityLogPermissions.SecurityLog.Default)]
    public class SecurityLogAppService : IdentityServerAppService, ISecurityLogAppService
    {
        protected IIdentitySecurityLogRepository SecurityLogRepository { get; }
        public SecurityLogAppService(IIdentitySecurityLogRepository securityLogRepository)
        {
            SecurityLogRepository = securityLogRepository;
        }
        public virtual async Task<SecurityLogDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<IdentitySecurityLog, SecurityLogDto>(await SecurityLogRepository.GetAsync(id));
        }

        public virtual async Task<PagedResultDto<SecurityLogDto>> GetListAsync(GetSecurityLogDto input)
        {
            var count = await SecurityLogRepository.GetCountAsync(
              startTime: input.StartTime,
              endTime: input.EndTime,
              applicationName: input.ApplicationName,
              identity: input.Identity,
              action: input.ActionName,
              userId: null,
              userName: input.UserName,
              clientId: input.ClientId,
              correlationId: input.CorrelationId
          );
            var list = await SecurityLogRepository.GetListAsync(
                sorting: input.Sorting,
                maxResultCount: input.MaxResultCount,
                skipCount: input.SkipCount,
                startTime: input.StartTime,
                endTime: input.EndTime,
                applicationName: input.ApplicationName,
                identity: input.Identity,
                action: input.ActionName,
                userId: null,
                userName: input.UserName,
                clientId: input.ClientId,
                correlationId: input.CorrelationId
            );
            return new PagedResultDto<SecurityLogDto>(
                count,
                ObjectMapper.Map<List<IdentitySecurityLog>, List<SecurityLogDto>>(list)
            );
        }
        [Authorize(SecurityLogPermissions.SecurityLog.Delete)]
        public virtual async Task DeleteManyAsync(params Guid[] ids)
        {
            foreach (var id in ids)
            {
                var securityLog = await SecurityLogRepository.GetAsync(id);
                await SecurityLogRepository.DeleteAsync(id);
            }
        }
        [Authorize(SecurityLogPermissions.SecurityLog.Delete)]
        public virtual async Task DeleteAsync(Guid id)
        {
            await SecurityLogRepository.DeleteAsync(id);
        }
    }
}
