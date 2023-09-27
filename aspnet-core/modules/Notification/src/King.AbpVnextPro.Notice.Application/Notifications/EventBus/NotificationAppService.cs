using King.AbpVnextPro.Notice.Notifications.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Auditing;
using Volo.Abp.Users;

namespace King.AbpVnextPro.Notice.Notifications.EventBus
{
    [DisableAuditing]
    public class NotificationAppService : NoticeAppService, INotificationAppService
    {
        private readonly INotificationManager _notificationManager;
        private readonly ICurrentUser _currentUser;
        private INotificationRepository _notificationRepository;

        public NotificationAppService(
            INotificationManager notificationManager,
            INotificationRepository notificationRepository,
            ICurrentUser currentUser)
        {
            _notificationManager = notificationManager;
            _notificationRepository = notificationRepository;
            _currentUser = currentUser;
        }


        /// <summary>
        /// 发送警告文本消息
        /// </summary>
        public virtual async Task SendCommonWarningMessageAsync(SendCommonMessageInput input)
        {
            await _notificationManager.SendCommonWarningMessageAsync(input.Title, input.Content, input.From, input.ReceiveIds);
        }

        /// <summary>
        /// 发送普通文本消息
        /// </summary>
        public virtual async Task SendCommonInformationMessageAsync(SendCommonMessageInput input)
        {
            await _notificationManager.SendCommonInformationMessageAsync(input.Title, input.Content, input.From, input.ReceiveIds);
        }

        /// <summary>
        /// 发送错误文本消息
        /// </summary>
        public async Task SendCommonErrorMessageAsync(SendCommonMessageInput input)
        {
            await _notificationManager.SendCommonErrorMessageAsync(input.Title, input.Content, input.From, input.ReceiveIds);
        }

        /// <summary>
        /// 发送警告广播消息
        /// </summary>
        public virtual async Task SendBroadCastWarningMessageAsync(SendBroadCastMessageInput input)
        {
            await _notificationManager.SendBroadCastWarningMessageAsync(input.Title, input.Content, input.Status, input.From, input.IsCreate);
        }

        /// <summary>
        /// 发送正常广播消息
        /// </summary>
        public virtual async Task SendBroadCastInformationMessageAsync(SendBroadCastMessageInput input)
        {
            await _notificationManager.SendBroadCastInformationMessageAsync(input.Title, input.Content, input.Status, input.From, input.IsCreate);
        }

        /// <summary>
        /// 发送错误广播消息
        /// </summary>
        public virtual async Task SendBroadCastErrorMessageAsync(SendBroadCastMessageInput input)
        {
            await _notificationManager.SendBroadCastErrorMessageAsync(input.Title, input.Content, input.Status, input.From, input.IsCreate);
        }
        /// <summary>
        /// 发送广播消息
        /// </summary>
        public virtual async Task SendOnlyBroadCastMessageAsync(Guid id)
        {
            await _notificationManager.SendOnlyBroadCastMessageAsync(id);
        }

        /// <summary>
        /// 删除消息
        /// </summary>
        public virtual async Task DeleteBroadCastMessageAsync(Guid id)
        {
            await _notificationRepository.DeleteAsync(id);
        }

        /// <summary>
        /// 更新消息
        /// </summary>
        public virtual async Task UpdateBroadCastMessageAsync(Guid id, SendBroadCastMessageInput input)
        {
            await _notificationManager.UpdateBroadCastMessageAsync(id, input.Title, input.Content, input.Status);
        }

        public virtual Task SetReadAsync(SetReadInput input)
        {
            return _notificationManager.SetReadAsync(input.Id);
        }


        /// <summary>
        /// 分页获取用户普通文本消息
        /// </summary>
        public virtual async Task<PagedResultDto<PagingNotificationListOutput>> GetPageCommonNotificationByUserIdAsync(PagingNotificationListInput listInput)
        {
            if (_currentUser == null || !_currentUser.Id.HasValue)
            {
                return null;
            }

            var totalCount = await _notificationManager.GetPagingCountAsync(_currentUser.Id.Value, MessageType.Common, listInput.Status, listInput.Title);
            var list = await _notificationManager.GetPagingListAsync(_currentUser.Id.Value, MessageType.Common, listInput.Status, listInput.Title, listInput.MaxResultCount, listInput.SkipCount);
            return new PagedResultDto<PagingNotificationListOutput>(totalCount, ObjectMapper.Map<List<Notification>, List<PagingNotificationListOutput>>(list));
        }

        /// <summary>
        /// 分页获取广播消息
        /// </summary>
        /// <param name="listInput"></param>
        /// <returns></returns>
        public virtual async Task<PagedResultDto<PagingNotificationListOutput>> GetPageBroadCastNotificationByUserIdAsync(PagingNotificationListInput listInput)
        {
            var totalCount = await _notificationManager.GetPagingCountAsync(null, MessageType.BroadCast, listInput.Status, listInput.Title);
            var list = await _notificationManager.GetPagingListAsync(null, MessageType.BroadCast, listInput.Status, listInput.Title, listInput.MaxResultCount, listInput.SkipCount);
            return new PagedResultDto<PagingNotificationListOutput>(totalCount, ObjectMapper.Map<List<Notification>, List<PagingNotificationListOutput>>(list));
        }

        /// <summary>
        /// 获取广播消息List
        /// </summary>
        /// <param name="listInput"></param>
        /// <returns></returns>
        public virtual async Task<List<PagingNotificationListOutput>> GetBroadCastNotificationByUserIdAsync(PagingNotificationListInput listInput)
        {
            var list = await _notificationManager.GetNoPagingListAsync(null, MessageType.BroadCast, listInput.Status, listInput.IsSend);
            return ObjectMapper.Map<List<Notification>, List<PagingNotificationListOutput>>(list);
        }

        /// <summary>
        /// 获取用户普通文本消息list
        /// </summary>
        public virtual async Task<List<PagingNotificationListOutput>> GetCommonNotificationByUserIdAsync(PagingNotificationListInput listInput)
        {
            if (_currentUser == null || !_currentUser.Id.HasValue)
            {
                return null;
            }

            var list = await _notificationManager.GetNoPagingListAsync(_currentUser.Id.Value, MessageType.Common, listInput.Status, listInput.IsSend);
            return ObjectMapper.Map<List<Notification>, List<PagingNotificationListOutput>>(list);
        }
    }
}
