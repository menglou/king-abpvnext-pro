﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserMemberAlipaybigcardQueryModel Data Structure.
    /// </summary>
    public class AlipayUserMemberAlipaybigcardQueryModel : AlipayObject
    {
        /// <summary>
        /// 缓存是否可用，手淘在请求前先查uid的缓存，新用户请求未落缓存或者上次缓存已经被清空时为false
        /// </summary>
        [JsonPropertyName("available_cache")]
        public bool AvailableCache { get; set; }

        /// <summary>
        /// 手淘CARD的渠道类型，新的渠道用TAOBAO_CARD，老的渠道不会传
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 手淘请求之前带上的当前时间戳
        /// </summary>
        [JsonPropertyName("request_time_mills")]
        public string RequestTimeMills { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，根据uid判别展示权益内容。由手淘直接传给支付宝
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
