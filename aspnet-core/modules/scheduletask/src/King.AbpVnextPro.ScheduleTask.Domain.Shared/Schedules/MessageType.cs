using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace King.AbpVnextPro.ScheduleTask.Schedules
{
    public enum MessageType
    {
        /// <summary>
        /// 广播消息
        /// </summary>
        [Description("广播消息")]
        BroadCast = 10,
        /// <summary>
        /// 普通文本消息
        /// </summary>
        [Description("普通文本消息")]
        Common = 20,

    }
}
