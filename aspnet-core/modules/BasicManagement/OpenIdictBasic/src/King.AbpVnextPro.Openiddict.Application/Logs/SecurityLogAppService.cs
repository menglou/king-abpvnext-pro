using King.AbpVnextPro.Openiddict;
using King.AbpVnextPro.Openiddict.Logs.AuditLogging;
using King.AbpVnextPro.Openiddict.Logs.SecurityLogs;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AuditLogging;
using Volo.Abp.Identity;
using static King.AbpVnextPro.Openiddict.Permissions.OpeniddictPermissions;

namespace King.AbpVnextPro.Openiddict.Logs
{
    [RemoteService(false)]
    
    public class SecurityLogAppService : OpeniddictAppService, ISecurityLogAppService
    {
        protected IIdentitySecurityLogRepository SecurityLogRepository { get; }
        public SecurityLogAppService(IIdentitySecurityLogRepository securityLogRepository)
        {
            SecurityLogRepository = securityLogRepository;
        }
        [Authorize(SecurityLogPermissions.SecurityLog.Default)]
        public virtual async Task<SecurityLogDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<IdentitySecurityLog, SecurityLogDto>(await SecurityLogRepository.GetAsync(id));
        }

        [Authorize(SecurityLogPermissions.SecurityLog.Default)]
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

        /// <summary>
        /// 删除日志 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public virtual async Task<MessageModelDto> AutoDeleteSecurityLogAsync(AutoDeleteSecurityLogDto input)
        {
            MessageModelDto messageModelDto = new MessageModelDto();
            try
            {
                DateTime time = DateTime.Now.AddDays(-input.RetainDay);

                var securityLogs = (await SecurityLogRepository.GetListAsync()).Where(x => x.CreationTime <= time);

                List<Guid> auditlogsid = securityLogs.Select(x => x.Id).ToList();

                await SecurityLogRepository.DeleteManyAsync(auditlogsid);

                messageModelDto.IsSuccesss = true;
                messageModelDto.Message = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} 删除登录日志成功！";
            }
            catch (Exception ex)
            {
                messageModelDto.IsSuccesss = false;
                messageModelDto.Message = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}  删除登录日志失败，失败原因：{ex.Message},StackTrace:{ex.StackTrace}";
            }
           
            return messageModelDto;

        }
    }
}
