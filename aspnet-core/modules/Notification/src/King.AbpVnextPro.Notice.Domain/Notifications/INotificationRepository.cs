using King.AbpVnextPro.Notice.Notifications.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace King.AbpVnextPro.Notice.Notifications
{
    /// <summary>
    /// 消息通知 仓储接口
    /// </summary>
    public partial interface INotificationRepository : IRepository<Notification, Guid>
    {
        /// <summary>
        /// 分页获取消息
        /// </summary>
        Task<List<Notification>> GetPagingListAsync(
            Guid? userId,
            MessageType messageType,
            int status,
            string title,
            int maxResultCount = 10,
            int skipCount = 0,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// 获取消息总条数
        /// </summary>
        Task<long> GetPagingCountAsync(Guid? userId, MessageType messageType, int status, string title, CancellationToken cancellationToken = default);

        Task<List<Notification>> GetNoPagingListAsync(
           Guid? userId,
           MessageType messageType,
           int status,
           bool isSend,
           CancellationToken cancellationToken = default);
    }
}
