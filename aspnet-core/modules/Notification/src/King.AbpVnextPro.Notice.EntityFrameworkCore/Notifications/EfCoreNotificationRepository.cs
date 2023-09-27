using King.AbpVnextPro.Notice.EntityFrameworkCore;
using King.AbpVnextPro.Notice.Notifications.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace King.AbpVnextPro.Notice.Notifications
{
    public class EfCoreNotificationRepository : EfCoreRepository<INoticeDbContext, Notification, Guid>,
         INotificationRepository
    {
        public EfCoreNotificationRepository(IDbContextProvider<INoticeDbContext> dbContextProvider) :
           base(dbContextProvider)
        {
        }

        /// <summary>
        /// 查找用户消息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Notification> FindByIdAsync(Guid id)
        {
            return await (await GetDbSetAsync())
                .IncludeDetails()
                .Where(e => e.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Notification>> GetPagingListAsync(
            Guid? userId,
            MessageType messageType,
            int status,
            string title,
            int maxResultCount = 10,
            int skipCount = 0,
            CancellationToken cancellationToken = default)
        {
            return await (await GetDbSetAsync())
                .IncludeDetails()
                .Where(e => e.MessageType == messageType)
                .Where(e => e.Status == status)
                .WhereIf(userId.HasValue, e => e.NotificationSubscriptions.Any(s => s.ReceiveId == userId))
                .WhereIf(!title.IsNullOrWhiteSpace(), e => e.Title.Contains(title))
                .OrderByDescending(e => e.CreationTime)
                .PageBy(skipCount, maxResultCount)
                .ToListAsync(GetCancellationToken(cancellationToken));
        }

        public async Task<List<Notification>> GetNoPagingListAsync(
           Guid? userId,
           MessageType messageType,
           int status,
           bool isSend,
           CancellationToken cancellationToken = default)
        {
            return await (await GetDbSetAsync())
                .IncludeDetails()
                .Where(e => e.MessageType == messageType)
                .Where(e => e.Status == status)
                .Where(e => e.IsSend == isSend)
                .WhereIf(userId.HasValue, e => e.NotificationSubscriptions.Any(s => s.ReceiveId == userId))
                .OrderByDescending(e => e.CreationTime)
                .ToListAsync(GetCancellationToken(cancellationToken));
        }

        public async Task<long> GetPagingCountAsync(Guid? userId, MessageType messageType, int status, string title, CancellationToken cancellationToken = default)
        {
            return await (await GetDbSetAsync())
                .Where(e => e.MessageType == messageType)
                .Where(e => e.Status == status)
                .WhereIf(userId.HasValue, e => e.NotificationSubscriptions.Any(s => s.ReceiveId == userId))
                   .WhereIf(!title.IsNullOrWhiteSpace(), e => e.Title.Contains(title))
                .CountAsync(cancellationToken: cancellationToken);
        }


        public override async Task<IQueryable<Notification>> WithDetailsAsync()
        {
            return (await GetQueryableAsync()).IncludeDetails();
        }
    }
}
