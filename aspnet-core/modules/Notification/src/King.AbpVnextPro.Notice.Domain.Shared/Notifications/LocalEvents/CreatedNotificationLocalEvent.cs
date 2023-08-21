using King.AbpVnextPro.Notice.Notifications.Etos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EventBus;

namespace King.AbpVnextPro.Notice.Notifications.LocalEvents
{
    [EventName("System.Notification")]
    public class CreatedNotificationLocalEvent
    {
        public NotificationEto NotificationEto { get; set; }

        private CreatedNotificationLocalEvent()
        {

        }

        public CreatedNotificationLocalEvent(NotificationEto notificationEto)
        {
            NotificationEto = notificationEto;
        }
    }
}
