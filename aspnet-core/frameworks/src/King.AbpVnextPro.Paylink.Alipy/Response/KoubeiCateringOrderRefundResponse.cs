﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringOrderRefundResponse.
    /// </summary>
    public class KoubeiCateringOrderRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展信息，json对象格式，key和value都为字符串
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 口碑端订单号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 退款明细列表
        /// </summary>
        [JsonPropertyName("refund_description_list")]
        public List<RefundDescriptionDTO> RefundDescriptionList { get; set; }

        /// <summary>
        /// 口碑退款单id
        /// </summary>
        [JsonPropertyName("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 是否需要重试，true-需要，false-不需要
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
