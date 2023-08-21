using King.AbpVnextPro.Openiddict;
using King.AbpVnextPro.Openiddict.Logs.SecurityLogs;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;
using static King.AbpVnextPro.Openiddict.Permissions.OpeniddictPermissions;

namespace King.AbpVnextPro.Openiddict.Logs
{
    [RemoteService(false)]
    [Authorize(SecurityLogPermissions.SecurityLog.Default)]
    public class SecurityLogAppService : OpeniddictAppService, ISecurityLogAppService
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
