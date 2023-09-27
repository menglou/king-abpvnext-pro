using King.AbpVnextPro.Notice.Notifications.Enums;
using King.AbpVnextPro.Notice.Notifications.LocalEvents;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace King.AbpVnextPro.Notice.Notifications
{
    /// <summary>
    /// 消息通知 
    /// </summary>
    public class Notification : FullAuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 消息标题
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public string Content { get; private set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        public MessageType MessageType { get; private set; }

        /// <summary>
        /// 消息等级
        /// </summary>
        public MessageLevel MessageLevel { get; private set; }

        /// <summary>
        /// 发送人
        /// </summary>
        public Guid? SenderId { get; private set; }


        /// <summary>
        /// 状态  0代表 正常 1代表关闭
        /// </summary>
        public int Status { get; private set; }

        /// <summary>
        /// true 代表已发送，false 代表未发送
        /// </summary>
        public bool IsSend { get; private set; }
        /// <summary>
        /// 从哪过来得
        /// </summary>
        public Guid? From { get; set; }

        /// <summary>
        /// 关联属性1:N 消息订阅者集合
        /// </summary>
        public List<NotificationSubscription> NotificationSubscriptions { get; private set; }

        protected Notification()
        {
            NotificationSubscriptions = new List<NotificationSubscription>();
        }

        public Notification(
            Guid id,
            string title,
            string content,
            MessageType messageType,
            MessageLevel messageLevel,
            Guid? senderId,
            int status,
            Guid? from,
            bool IsSend
        ) : base(id)
        {
            NotificationSubscriptions = new List<NotificationSubscription>();

            SetProperties(
                title,
                content,
                messageType,
                messageLevel,
                senderId,
                status,
                from,
                IsSend
            );
        }

        internal void SetProperties(
            string title,
            string content,
            MessageType messageType,
            MessageLevel messageLevel,
            Guid? senderId,
            int status,
            Guid? from,
            bool isSend
        )
        {
            SetTitle(title);
            SetContent(content);
            SetMessageType(messageType);
            SetMessageLevel(messageLevel);
            SetSenderId(senderId);
            SetStatus(status);
            SetFrom(from);
            SetIsSend(isSend);
        }

        internal void SetSenderId(Guid? senderId)
        {
            SenderId = senderId;
        }

        internal void SetTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException(nameof(title));
            }
            if (title.Length > 256)
            {
                throw new ArgumentOutOfRangeException(nameof(title));
            }
            if (0 > 0 && title.Length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(title));
            }

            Title = title;
        }

        internal void SetContent(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentNullException(nameof(content));
            }

            if (0 > 0 && content.Length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(content));
            }
            Content = content;
        }

        internal void SetMessageType(MessageType messageType)
        {
            MessageType = messageType;
        }

        internal void SetMessageLevel(MessageLevel messageLevel)
        {
            MessageLevel = messageLevel;
        }

        internal void SetStatus(int status)
        {
            Status = status;
        }

        internal void SetIsSend(bool isSend)
        {
            IsSend = isSend;
        }

        internal void SetFrom(Guid? from)
        {
            From = from;
        }

        /// <summary>
        /// 新增非广播消息订阅人
        /// </summary>
        public void AddNotificationSubscription(Guid notificationSubscriptionId, Guid receiveId)
        {
            if (NotificationSubscriptions.Any(e => e.ReceiveId == receiveId)) return;
            NotificationSubscriptions.Add(
                new NotificationSubscription(notificationSubscriptionId, Id, receiveId));
        }

        /// <summary>
        /// 新增消息类型为广播订阅人
        /// </summary>
        public void AddBroadCastNotificationSubscription(Guid notificationSubscriptionId, Guid receiveId, DateTime readTime)
        {
            if (NotificationSubscriptions.Any(e => e.ReceiveId == receiveId))
            {
                return;
            }

            var temp = new NotificationSubscription(notificationSubscriptionId, Id, receiveId);
            temp.SetRead(readTime);
            NotificationSubscriptions.Add(temp);
        }

        /// <summary>
        /// 添加创建消息事件
        /// </summary>
        public void AddCreatedNotificationLocalEvent(
            CreatedNotificationLocalEvent createdNotificationLocalEvent)
        {
            AddDistributedEvent(createdNotificationLocalEvent);
        }
    }
}
