using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.Openiddict.Logs.SecurityLogs
{
   public interface ISecurityLogAppService: IReadOnlyAppService<SecurityLogDto, Guid, GetSecurityLogDto>, IDeleteAppService<Guid>
    {
        Task DeleteManyAsync(params Guid[] ids);
    }
}
