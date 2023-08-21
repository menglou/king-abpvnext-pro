﻿using System.Xml.Serialization;

namespace King.AbpVnextPro.Paylink.WeChat.V2
{
    /// <summary>
    /// WeChatPay V2 通知对象
    /// </summary>
    public abstract class WeChatPayNotify : WeChatPayObject
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [XmlIgnore]
        public string Body { get; set; }

        /// <summary>
        /// 原始参数
        /// </summary>
        [XmlIgnore]
        public WeChatPayDictionary Parameters { get; internal set; }

        /// <summary>
        /// 处理 _$n / _$n_$m
        /// </summary>
        internal virtual void Execute() { }
    }
}
