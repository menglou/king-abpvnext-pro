using King.AbpVnextPro.Notice.Notifications.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.Notice.Notifications.Hub
{
    public interface INotificationHubAppService : IApplicationService
    {
        Task SendMessageAsync(Guid id, string title, string content, MessageType messageType, MessageLevel messageLevel, List<string> users);
    }
}
