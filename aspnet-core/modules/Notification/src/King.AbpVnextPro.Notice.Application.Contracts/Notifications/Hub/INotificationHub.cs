using System;
using System.Collections.Generic;
using System.Text;

namespace King.AbpVnextPro.Notice.Notifications.Hub
{
    public interface INotificationHub
    {
        /// <summary>
        /// 发送普通消息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task ReceiveTextMessageAsync(SendNotificationDto input);

        /// <summary>
        /// 发送广播消息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task ReceiveBroadCastMessageAsync(SendNotificationDto input);

        Task SysNoticeAsync(List<PagingNotificationListOutput> input);
    }
}
