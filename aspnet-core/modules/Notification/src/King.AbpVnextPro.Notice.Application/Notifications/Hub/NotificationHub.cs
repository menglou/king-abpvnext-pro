using King.AbpVnextPro.Notice.Notifications.EventBus;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.SignalR;
using Volo.Abp.Auditing;

namespace King.AbpVnextPro.Notice.Notifications.Hub
{
    [Authorize]
    public class NotificationHub : AbpHub<INotificationHub>
    {
        protected INotificationAppService _notificationAppService;
        public NotificationHub(INotificationAppService notificationAppService)
        {
            
            _notificationAppService = notificationAppService;
        }


        public async override Task OnConnectedAsync()
        {
            //判断用户是否存在，否则添加集合!user2 && !user && 
            if (CurrentUser.IsAuthenticated == true)
            {
                await Clients.All.SysNoticeAsync(await _notificationAppService.GetBroadCastNotificationByUserIdAsync(new PagingNotificationListInput() { Status = 0 }));
            }
            //在线人数
            //Clients.All.SendAsync(HubsConstant.OnlineNum, clientUsers.Count);

            await base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
