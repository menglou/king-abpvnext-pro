using King.AbpVnextPro.Notice.Notifications.EventBus;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.Notice.Notifications
{
    [Authorize]
    [RemoteService(Name = "Notification")]
    [ControllerName("Notification")]
    [Area("notification")]
    [Route("/api/notifications/notification")]
    public class NotificationController: NoticeController, INotificationAppService
    {
        private readonly INotificationAppService _notificationAppService;

        public NotificationController(
            INotificationAppService notificationAppService)
        {
            _notificationAppService = notificationAppService;
        }


        /// <summary>
        /// 分页获取用户普通文本消息
        /// </summary>x
        [HttpGet("CommonPageList")]
        public virtual Task<PagedResultDto<PagingNotificationListOutput>>
            GetPageCommonNotificationByUserIdAsync(
                PagingNotificationListInput listInput)
        {
            return _notificationAppService.GetPageCommonNotificationByUserIdAsync(listInput);
        }

        /// <summary>
        /// 分页获取广播消息
        /// </summary>
        [HttpGet("BroadCastPageList")]
        public virtual Task<PagedResultDto<PagingNotificationListOutput>>
            GetPageBroadCastNotificationByUserIdAsync(
                PagingNotificationListInput listInput)
        {
            return _notificationAppService.GetPageBroadCastNotificationByUserIdAsync(listInput);
        }

        /// <summary>
        /// 获取广播消息集合
        /// </summary>
        [HttpGet("BroadCastList")]
        public virtual Task<List<PagingNotificationListOutput>> GetBroadCastNotificationByUserIdAsync(PagingNotificationListInput listInput)
        {
            return _notificationAppService.GetBroadCastNotificationByUserIdAsync(listInput);
        }
        /// <summary>
        /// 获取普通用户文本消息集合
        /// </summary>
        [HttpGet("CommonNotificationList")]
        public  virtual Task<List<PagingNotificationListOutput>> GetCommonNotificationByUserIdAsync(PagingNotificationListInput listInput)
        {
            return _notificationAppService.GetCommonNotificationByUserIdAsync(listInput);
        }

        [HttpPost("SendCommonWarningMessage")]
        public Task SendCommonWarningMessageAsync(SendCommonMessageInput input)
        {
            return _notificationAppService.SendCommonWarningMessageAsync(input);
        }

        [HttpPost("SendCommonInformationMessage")]
        public virtual Task SendCommonInformationMessageAsync(SendCommonMessageInput input)
        {
            return _notificationAppService.SendCommonInformationMessageAsync(input);
        }

        [HttpPost("SendCommonErrorMessage")]
        public virtual Task SendCommonErrorMessageAsync(SendCommonMessageInput input)
        {
            return _notificationAppService.SendCommonErrorMessageAsync(input);
        }

        [HttpPost("SendBroadCastWarningMessage")]
        public virtual Task SendBroadCastWarningMessageAsync(SendBroadCastMessageInput input)
        {
            return _notificationAppService.SendBroadCastWarningMessageAsync(input);
        }

        [HttpPost("SendBroadCastInformationMessage")]
        public virtual Task SendBroadCastInformationMessageAsync(SendBroadCastMessageInput input)
        {
            return _notificationAppService.SendBroadCastInformationMessageAsync(input);
        }

        [HttpPost("SendBroadCastErrorMessage")]
        public virtual Task SendBroadCastErrorMessageAsync(SendBroadCastMessageInput input)
        {
            return _notificationAppService.SendBroadCastErrorMessageAsync(input);
        }
        [HttpGet("SendOnlyBroadCastMessage/{id}")]
        public virtual Task SendOnlyBroadCastMessageAsync(Guid id)
        {
            return _notificationAppService.SendOnlyBroadCastMessageAsync(id);
        }

        [HttpPost("Read")]
        public virtual Task SetReadAsync(SetReadInput input)
        {
            return _notificationAppService.SetReadAsync(input);
        }
        [HttpDelete("DeleteBroadCast/{id}")]
        public Task DeleteBroadCastMessageAsync(Guid id)
        {
            return _notificationAppService.DeleteBroadCastMessageAsync(id);
        }
        [HttpPut("UpdateBroadCast/{id}")]
        public virtual Task UpdateBroadCastMessageAsync(Guid id, SendBroadCastMessageInput input)
        {
            return _notificationAppService.UpdateBroadCastMessageAsync(id, input);
        }
    }
}
