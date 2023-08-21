using AutoMapper;
using King.AbpVnextPro.Notice.Notifications;

namespace King.AbpVnextPro.Notice;

public class NoticeApplicationAutoMapperProfile : Profile
{
    public NoticeApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Notification, PagingNotificationListOutput>()
           .ForMember(dest => dest.Read, opt => opt.MapFrom(e => e.NotificationSubscriptions.FirstOrDefault().Read));
    }
}
