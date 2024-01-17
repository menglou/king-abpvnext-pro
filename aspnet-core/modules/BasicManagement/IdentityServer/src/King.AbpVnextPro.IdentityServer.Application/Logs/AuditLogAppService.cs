using King.AbpVnextPro.IdentityServer.Logs.AuditLogging;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AuditLogging;
using static King.AbpVnextPro.IdentityServer.Permissions.IdentityServerPermissions;

namespace King.AbpVnextPro.IdentityServer.Logs
{
    [RemoteService(false)]
   
    public class AuditLogAppService: IdentityServerAppService, IAuditLogAppService
    {
        protected IAuditLogRepository AuditLogRepository { get; }
        public AuditLogAppService(IAuditLogRepository auditLogRepository)
        {
            AuditLogRepository = auditLogRepository;
        }
        [Authorize(AuditLogPermissions.AuditLogs.Default)]
        public virtual async Task<AuditLogDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<AuditLog, AuditLogDto>(await AuditLogRepository.GetAsync(id));
        }
        [Authorize(AuditLogPermissions.AuditLogs.Default)]
        public virtual async Task<PagedResultDto<AuditLogDto>> GetListAsync(GetAuditLogDto input)
        {
            var count = await AuditLogRepository.GetCountAsync(
                startTime: input.StartTime,
                endTime: input.EndTime,
                httpMethod: input.HttpMethod,
                url: input.Url,
                userName: input.UserName,
                applicationName: input.ApplicationName,
                correlationId: input.CorrelationId,
                maxExecutionDuration: input.MaxExecutionDuration,
                minExecutionDuration: input.MinExecutionDuration,
                hasException: input.HasException,
                httpStatusCode: input.HttpStatusCode
            );
            var list = await AuditLogRepository.GetListAsync(
                sorting: input.Sorting,
                maxResultCount: input.MaxResultCount,
                skipCount: input.SkipCount,
                startTime: input.StartTime,
                endTime: input.EndTime,
                httpMethod: input.HttpMethod,
                url: input.Url,
                userName: input.UserName,
                applicationName: input.ApplicationName,
                correlationId: input.CorrelationId,
                maxExecutionDuration: input.MaxExecutionDuration,
                minExecutionDuration: input.MinExecutionDuration,
                hasException: input.HasException,
                httpStatusCode: input.HttpStatusCode,
                includeDetails: input.IncludeDetails
            );
            return new PagedResultDto<AuditLogDto>(
                count,
                ObjectMapper.Map<List<AuditLog>, List<AuditLogDto>>(list)
            );
        }

        [Authorize(AuditLogPermissions.AuditLogs.Delete)]
        public virtual async Task DeleteAsync(Guid id)
        {
            await AuditLogRepository.DeleteAsync(id);
        }

        [Authorize(AuditLogPermissions.AuditLogs.Delete)]
        public virtual async Task DeleteManyAsync(params Guid[] ids)
        {
            foreach (var id in ids)
            {
                var auditLog = await AuditLogRepository.GetAsync(id);
                auditLog.EntityChanges.Clear();
                auditLog.Actions.Clear();
                await AuditLogRepository.DeleteAsync(id);
            }
        }

        /// <summary>
        /// 删除日志 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public virtual async Task<MessageModelDto> AutoDeleteAuditLogAsync(AutoDeleteAuditLogParamDto input)
        {
            MessageModelDto messageModelDto = new MessageModelDto();
            try
            {
                DateTime time = DateTime.Now.AddDays(-input.RetainDay);

                var auditlogs = await AuditLogRepository.GetListAsync(x => x.ExecutionTime <= time, includeDetails: true);

                List<Guid> auditlogsid = auditlogs.Select(x => x.Id).ToList();

                foreach (var id in auditlogsid)
                {
                    var auditLog = await AuditLogRepository.GetAsync(id);
                    auditLog.EntityChanges.Clear();
                    auditLog.Actions.Clear();
                    await AuditLogRepository.DeleteAsync(id);
                }

                messageModelDto.IsSuccesss = true;
                messageModelDto.Message = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}删除审计日成功！";
            }
            catch (Exception ex)
            {
                messageModelDto.IsSuccesss = false;
                messageModelDto.Message = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} 删除审计日志失败，失败原因：{ex.Message},StackTrace:{ex.StackTrace}";
            }
            return messageModelDto;
        }
    }
}
