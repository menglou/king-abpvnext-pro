using King.AbpVnextPro.Notice.Notifications.Enums;
using King.AbpVnextPro.Notice.Notifications.Etos;
using King.AbpVnextPro.Notice.Notifications.LocalEvents;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Authorization;
using Volo.Abp.Users;

namespace King.AbpVnextPro.Notice.Notifications
{
    public class NotificationManager : NotificationDomainService, INotificationManager
    {
        private readonly INotificationRepository _notificationRepository;

        private readonly ICurrentUser _currentUser;
       
        public NotificationManager(INotificationRepository notificationRepository, ICurrentUser currentUser)
        {
            _notificationRepository = notificationRepository;
            _currentUser = currentUser;
        }

        /// <summary>
        /// 分页获取消息
        /// </summary>
        public async Task<List<Notification>> GetPagingListAsync(
            Guid? userId,
            MessageType messageType,
              int status,
              string title,
            int maxResultCount = 10,
            int skipCount = 0)
        {
            return await _notificationRepository.GetPagingListAsync(userId, messageType, status, title, maxResultCount, skipCount);
        }

        /// <summary>
        /// 分页获取消息
        /// </summary>
        public async Task<List<Notification>> GetNoPagingListAsync(
            Guid? userId,
            MessageType messageType,
             int status
            )
        {
            return await _notificationRepository.GetNoPagingListAsync(userId, messageType, status);
        }

        /// <summary>
        /// 获取消息总条数
        /// </summary>
        public async Task<long> GetPagingCountAsync(Guid? userId, MessageType messageType, int status, string title)
        {
            return await _notificationRepository.GetPagingCountAsync(userId, messageType, status, title);
        }

        /// <summary>
        /// 发送警告文本消息
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">消息内容</param>
        /// <param name="receiveIds">接受人，发送给谁。</param>
        public async Task SendCommonWarningMessageAsync(string title, string content, Guid? from, List<Guid> receiveIds)
        {
            if (receiveIds is { Count: 0 })
            {
                throw new NotificationDomainException(NoticeErrorCodes.ReceiverNotNull);
            }

            var senderId = Guid.Empty;
            if (_currentUser?.Id != null)
            {
                senderId = _currentUser.Id.Value;
            }
            
            var entity = new Notification(GuidGenerator.Create(), title, content, MessageType.Common, MessageLevel.Warning, senderId, 0, from);
            foreach (var item in receiveIds)
            {
                entity.AddNotificationSubscription(GuidGenerator.Create(), item);
            }

            var notificationEto = ObjectMapper.Map<Notification, NotificationEto>(entity);
            // 发送集成事件
            entity.AddCreatedNotificationLocalEvent(new CreatedNotificationLocalEvent(notificationEto));
            await _notificationRepository.InsertAsync(entity);
        }

        /// <summary>
        /// 发送普通文本消息
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">消息内容</param>
        /// <param name="receiveIds">接受人，发送给谁。</param>
        public async Task SendCommonInformationMessageAsync(string title, string content, Guid? from, List<Guid> receiveIds)
        {
            if (receiveIds is { Count: 0 })
            {
                throw new NotificationDomainException(NoticeErrorCodes.ReceiverNotNull);
            }

            var senderId = Guid.Empty;
            if (_currentUser?.Id != null)
            {
                senderId = _currentUser.Id.Value;
            }

            var entity = new Notification(GuidGenerator.Create(), title, content, MessageType.Common, MessageLevel.Information, senderId, 0, from);
            foreach (var item in receiveIds)
            {
                entity.AddNotificationSubscription(GuidGenerator.Create(), item);
            }

            var notificationEto = ObjectMapper.Map<Notification, NotificationEto>(entity);
            // 发送集成事件
            entity.AddCreatedNotificationLocalEvent(new CreatedNotificationLocalEvent(notificationEto));
            await _notificationRepository.InsertAsync(entity);
        }

        /// <summary>
        /// 发送错误文本消息
        /// </summary>
        public async Task SendCommonErrorMessageAsync(string title, string content, Guid? from, List<Guid> receiveIds)
        {
            if (receiveIds is { Count: 0 })
            {
                throw new NotificationDomainException(NoticeErrorCodes.ReceiverNotNull);
            }

            var senderId = Guid.Empty;
            if (_currentUser?.Id != null)
            {
                senderId = _currentUser.Id.Value;
            }

            var entity = new Notification(GuidGenerator.Create(), title, content, MessageType.Common, MessageLevel.Error, senderId, 0, from);
            foreach (var item in receiveIds)
            {
                entity.AddNotificationSubscription(GuidGenerator.Create(), item);
            }

            var notificationEto = ObjectMapper.Map<Notification, NotificationEto>(entity);
            // 发送集成事件
            entity.AddCreatedNotificationLocalEvent(new CreatedNotificationLocalEvent(notificationEto));
            await _notificationRepository.InsertAsync(entity);
        }

        /// <summary>
        /// 发送警告广播消息
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">消息内容</param>
        /// <param name="status">状态 0 代表正常 1 代表关闭</param>
        /// <param name="iscreate">是否仅仅只创建消息</param>
        public async Task SendBroadCastWarningMessageAsync(string title, string content, int status, Guid? from, bool iscreate = false)
        {
            var senderId = Guid.Empty;
            if (_currentUser?.Id != null)
            {
                senderId = _currentUser.Id.Value;
            }

            var entity = new Notification(GuidGenerator.Create(), title, content, MessageType.BroadCast, MessageLevel.Warning, senderId, status, from);
            var notificationEto = ObjectMapper.Map<Notification, NotificationEto>(entity);
            if (iscreate == false)
            {
                await _notificationRepository.InsertAsync(entity);
            }
            else
            {
                // 发送集成事件
                entity.AddCreatedNotificationLocalEvent(new CreatedNotificationLocalEvent(notificationEto));
                await _notificationRepository.InsertAsync(entity);
            }
        }



        /// <summary>
        /// 发送正常广播消息
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">消息内容</param>
        /// <param name="status">状态 0 代表正常 1 代表关闭</param>
        /// <param name="iscreate">是否仅仅只创建消息</param>
        public async Task SendBroadCastInformationMessageAsync(string title, string content, int status, Guid? from, bool iscreate = false)
        {
            var senderId = Guid.Empty;
            if (_currentUser?.Id != null)
            {
                senderId = _currentUser.Id.Value;
            }

            var entity = new Notification(GuidGenerator.Create(), title, content, MessageType.BroadCast, MessageLevel.Information, senderId, status, from);
            var notificationEto = ObjectMapper.Map<Notification, NotificationEto>(entity);
            if (iscreate == false)
            {
                await _notificationRepository.InsertAsync(entity);
            }
            else
            {
                // 发送集成事件
                entity.AddCreatedNotificationLocalEvent(new CreatedNotificationLocalEvent(notificationEto));
                await _notificationRepository.InsertAsync(entity);
            }

        }

        /// <summary>
        /// 发送错误广播消息
        /// <param name="title">标题</param>
        /// <param name="content">消息内容</param>
        /// <param name="status">状态 0 代表正常 1 代表关闭</param>
        /// <param name="iscreate">是否仅仅只创建消息</param>
        public async Task SendBroadCastErrorMessageAsync(string title, string content, int status, Guid? from, bool iscreate = false)
        {
            var senderId = Guid.Empty;
            if (_currentUser?.Id != null)
            {
                senderId = _currentUser.Id.Value;
            }

            var entity = new Notification(GuidGenerator.Create(), title, content, MessageType.BroadCast, MessageLevel.Error, senderId, status, from);
            var notificationEto = ObjectMapper.Map<Notification, NotificationEto>(entity);
            if (iscreate == false)
            {
                await _notificationRepository.InsertAsync(entity);
            }
            else
            {
                // 发送集成事件
                entity.AddCreatedNotificationLocalEvent(new CreatedNotificationLocalEvent(notificationEto));
                await _notificationRepository.InsertAsync(entity);
            }
        }

        public async Task SendOnlyBroadCastMessageAsync(Guid id)
        {
            var entity = await _notificationRepository.FindAsync(id);
            var notificationEto = ObjectMapper.Map<Notification, NotificationEto>(entity);
            // 发送集成事件
            entity.AddCreatedNotificationLocalEvent(new CreatedNotificationLocalEvent(notificationEto));
        }

        /// <summary>
        /// 更新消息
        /// </summary>
        public async Task UpdateBroadCastMessageAsync(Guid id, string title, string content, int status)
        {
            var res = await _notificationRepository.FindAsync(id);
            if (res != null)
            {
                res.SetProperties(title, content, res.MessageType, res.MessageLevel, res.SenderId, status, res.From);

                await _notificationRepository.UpdateAsync(res);
            }
        }

        /// <summary>
        /// 消息设置为已读
        /// </summary>
        /// <param name="id">消息Id</param>
        public async Task SetReadAsync(Guid id)
        {
            if (_currentUser is not { IsAuthenticated: true }) throw new AbpAuthorizationException();

            var notification = await _notificationRepository.FindByIdAsync(id);

            if (notification == null) throw new NotificationDomainException(NoticeErrorCodes.MessageNotExist);
            if (notification.MessageType == MessageType.BroadCast)
            {
                //如果类型是广播消息，用户设置为已读，在插入一条数据
                notification.AddBroadCastNotificationSubscription(GuidGenerator.Create(), _currentUser.GetId(), Clock.Now);
                return;
            }
            else
            {
                var notificationSubscription = notification.NotificationSubscriptions.FirstOrDefault(e => e.ReceiveId == _currentUser.GetId());
                if (notificationSubscription == null)
                    throw new NotificationDomainException(NoticeErrorCodes.UserUnSubscription);
                notificationSubscription.SetRead(Clock.Now);
            }

            await _notificationRepository.UpdateAsync(notification);
        }
    }
}
