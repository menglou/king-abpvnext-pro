﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayTradeRoyaltyRelationBindModel Data Structure.
    /// </summary>
    public class AlipayTradeRoyaltyRelationBindModel : AlipayObject
    {
        /// <summary>
        /// 外部请求号，由商家自定义。32个字符以内，仅可包含字母、数字、下划线。需保证在商户端不重复。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分账接收方列表，单次传入最多20个
        /// </summary>
        [JsonPropertyName("receiver_list")]
        public List<RoyaltyEntity> ReceiverList { get; set; }
    }
}
