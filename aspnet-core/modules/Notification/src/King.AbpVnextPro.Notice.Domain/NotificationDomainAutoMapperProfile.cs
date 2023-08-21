using King.AbpVnextPro.Notice.Notifications.Etos;
using King.AbpVnextPro.Notice.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace King.AbpVnextPro.Notice
{
    public class NotificationDomainAutoMapperProfile : Profile
    {
        public NotificationDomainAutoMapperProfile()
        {
            CreateMap<Notification, NotificationEto>();
            CreateMap<NotificationSubscription, NotificationSubscriptionEto>();
        }
    }
}
