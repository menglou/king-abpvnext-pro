using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using King.AbpVnextPro.Notice.Notifications.Enums;

namespace King.AbpVnextPro.Notice.Notifications
{
    public class PagingNotificationListOutput
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 消息标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        public MessageType MessageType { get; set; }

        public string MessageTypeDescription => MessageType.ToDescription();

        /// <summary>
        /// 消息等级
        /// </summary>
        public MessageLevel MessageLevel { get; set; }

        public string MessageLevelDescription => MessageLevel.ToDescription();

        /// <summary>
        /// 发送人
        /// </summary>
        public Guid SenderId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 是否已读
        /// </summary>
        public bool Read { get; set; }


        public int Status { get; set; }

        public Guid From { get; set; }

    }

    public static class EnumExtensions
    {
        /// <summary>
        /// 获取枚举项上的<see cref="DescriptionAttribute"/>特性的文字描述
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToDescription(this Enum value)
        {
            var type = value.GetType();
            var member = type.GetMember(value.ToString()).FirstOrDefault();

            return member != null ? member.GetDescription() : value.ToString();
        }

        /// <summary>
        /// 获取成员元数据的Description特性描述信息。
        /// </summary>
        /// <param name="member">成员元数据对象。</param>
        /// <param name="inherit">是否搜索成员的继承链以查找描述特性。</param>
        /// <returns>返回Description特性描述信息，如不存在则返回成员的名称。</returns>
        private static string GetDescription(this MemberInfo member, bool inherit = true)
        {
            var desc = member.GetAttribute<DescriptionAttribute>(inherit);
            if (desc != null)
            {
                return desc.Description;
            }

            var displayName = member.GetAttribute<DisplayNameAttribute>(inherit);
            if (displayName != null)
            {
                return displayName.DisplayName;
            }

            var display = member.GetAttribute<DisplayAttribute>(inherit);
            return display != null ? display.Name : member.Name;
        }

        public static T GetAttribute<T>(this MemberInfo memberInfo, bool inherit = true) where T : Attribute
        {
            var attributes = memberInfo.GetCustomAttributes(typeof(T), inherit);
            return attributes.FirstOrDefault() as T;
        }
    }
}
