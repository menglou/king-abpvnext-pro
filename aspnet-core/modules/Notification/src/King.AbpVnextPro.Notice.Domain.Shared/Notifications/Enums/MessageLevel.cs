using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace King.AbpVnextPro.Notice.Notifications.Enums
{
    /// <summary>
    /// 消息等级
    /// </summary>
    public enum MessageLevel
    {
        /// <summary>
        /// 警告
        /// </summary>
        [Description("警告")]
        Warning = 10,
        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")]
        Information = 20,
        /// <summary>
        /// 错误
        /// </summary>
        [Description("错误")]
        Error = 30,
        /// <summary>
        /// 错误
        /// </summary>
        [Description("严重")]
        Severity = 40,
        /// <summary>
        /// 错误
        /// </summary>
        [Description("一般")]
        Normal = 50,
    }
}
