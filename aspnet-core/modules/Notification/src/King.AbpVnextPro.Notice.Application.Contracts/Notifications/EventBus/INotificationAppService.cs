using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.Notice.Notifications.EventBus
{
    public interface INotificationAppService : IApplicationService
    {

        /// <summary>
        /// 发送警告文本消息
        /// </summary>
        Task SendCommonWarningMessageAsync(SendCommonMessageInput input);

        /// <summary>
        /// 发送普通文本消息
        /// </summary>
        Task SendCommonInformationMessageAsync(SendCommonMessageInput input);

        /// <summary>
        /// 发送错误文本消息
        /// </summary>
        Task SendCommonErrorMessageAsync(SendCommonMessageInput input);

        /// <summary>
        /// 发送警告广播消息
        /// </summary>
        Task SendBroadCastWarningMessageAsync(SendBroadCastMessageInput input);

        /// <summary>
        /// 发送正常广播消息
        /// </summary>
        Task SendBroadCastInformationMessageAsync(SendBroadCastMessageInput input);

        /// <summary>
        /// 发送错误广播消息
        /// </summary>
        Task SendBroadCastErrorMessageAsync(SendBroadCastMessageInput input);
        /// <summary>
        /// 仅仅发送广播消息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task SendOnlyBroadCastMessageAsync(Guid id);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteBroadCastMessageAsync(Guid id);
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UpdateBroadCastMessageAsync(Guid id, SendBroadCastMessageInput input);
        /// <summary>
        /// 消息设置为已读
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task SetReadAsync(SetReadInput input);

        /// <summary>
        /// 分页获取用户普通文本消息
        /// </summary>
        /// <param name="listInput"></param>
        /// <returns></returns>
        Task<PagedResultDto<PagingNotificationListOutput>> GetPageCommonNotificationByUserIdAsync(
            PagingNotificationListInput listInput);

        /// <summary>
        /// 分页获取广播消息
        /// </summary>
        /// <param name="listInput"></param>
        /// <returns></returns>
        Task<PagedResultDto<PagingNotificationListOutput>> GetPageBroadCastNotificationByUserIdAsync(
            PagingNotificationListInput listInput);

        Task<List<PagingNotificationListOutput>> GetBroadCastNotificationByUserIdAsync(PagingNotificationListInput listInput);
        Task<List<PagingNotificationListOutput>> GetCommonNotificationByUserIdAsync(PagingNotificationListInput listInput);
    }
}
