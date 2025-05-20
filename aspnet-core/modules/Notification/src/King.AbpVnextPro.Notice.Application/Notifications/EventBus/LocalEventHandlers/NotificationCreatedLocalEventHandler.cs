using King.AbpVnextPro.Notice.Notifications.Hub;
using King.AbpVnextPro.Notice.Notifications.LocalEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus;
using Volo.Abp.EventBus.Distributed;

namespace King.AbpVnextPro.Notice.Notifications.EventBus.LocalEventHandlers
{
    /// <summary>
    /// 创建消息事件处理
    /// </summary>
    public class NotificationCreatedLocalEventHandler : IDistributedEventHandler<CreatedNotificationLocalEvent>, ITransientDependency
    {
        protected readonly INotificationHubAppService _hubAppService;

        public NotificationCreatedLocalEventHandler(INotificationHubAppService hubAppService)
        {
            _hubAppService = hubAppService;
        }

        public virtual Task HandleEventAsync(CreatedNotificationLocalEvent eventData)
        {
            return _hubAppService.SendMessageAsync(
                eventData.NotificationEto.Id,
                eventData.NotificationEto.Title,
                eventData.NotificationEto.Content,
                eventData.NotificationEto.MessageType,
                eventData.NotificationEto.MessageLevel,
                eventData.NotificationEto.NotificationSubscriptions.Select(e => e.ReceiveId.ToString()).ToList());
        }

    }
}
