using King.AbpVnextPro.Notice.Notifications.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Services;

namespace King.AbpVnextPro.Notice.Notifications
{
    public interface INotificationManager : IDomainService
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
            int skipCount = 0);

        /// <summary>
        /// 获取消息总条数
        /// </summary>
        Task<long> GetPagingCountAsync(Guid? userId, MessageType messageType, int status, string title);

        /// <summary>
        /// 获取消息列表
        /// </summary>
        Task<List<Notification>> GetNoPagingListAsync(
           Guid? userId,
           MessageType messageType,
            int status,
            bool isSend
          );

        /// <summary>
        /// 发送警告文本消息
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">消息内容</param>
        /// <param name="receiveIds">接受人，发送给谁。</param>
        Task SendCommonWarningMessageAsync(string title, string content, Guid? from, List<Guid> receiveIds);

        /// <summary>
        /// 发送普通文本消息
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">消息内容</param>
        /// <param name="receiveIds">接受人，发送给谁。</param>
        Task SendCommonInformationMessageAsync(string title, string content, Guid? from, List<Guid> receiveIds);

        /// <summary>
        /// 发送错误文本消息
        /// </summary>
        Task SendCommonErrorMessageAsync(string title, string content, Guid? from, List<Guid> receiveIds);

        /// <summary>
        /// 发送警告广播消息
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">消息内容</param>
        Task SendBroadCastWarningMessageAsync(string title, string content, int status, Guid? from, bool iscreate = false);

        /// <summary>
        /// 发送正常广播消息
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">消息内容</param>
        Task SendBroadCastInformationMessageAsync(string title, string content, int status, Guid? from, bool iscreate = false);

        /// <summary>
        /// 发送错误广播消息
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">消息内容</param>
        Task SendBroadCastErrorMessageAsync(string title, string content, int status, Guid? from, bool iscreate = false);

        Task SendOnlyBroadCastMessageAsync(Guid id);
        Task UpdateMessageAsync(Guid id, string title, string content, int status);
        /// <summary>
        /// 消息设置为已读
        /// </summary>
        /// <param name="id">消息Id</param>
        Task SetReadAsync(Guid id);

        IAbpLazyServiceProvider LazyServiceProvider { get; set; }
        IServiceProvider ServiceProvider { get; set; }
    }
}
