﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsSceneSellerActivitySignModel Data Structure.
    /// </summary>
    public class AlipayInsSceneSellerActivitySignModel : AlipayObject
    {
        /// <summary>
        /// 关于签约的附加信息
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 渠道账号对应的uid，如果证据类型字段没填则必填
        /// </summary>
        [JsonPropertyName("channel_account_id")]
        public string ChannelAccountId { get; set; }

        /// <summary>
        /// 渠道账号类型,如果证据类型字段没填则必填1:支付宝账号 2:淘宝账号
        /// </summary>
        [JsonPropertyName("channel_account_type")]
        public long ChannelAccountType { get; set; }

        /// <summary>
        /// 标准产品编号
        /// </summary>
        [JsonPropertyName("sp_code")]
        public string SpCode { get; set; }
    }
}
