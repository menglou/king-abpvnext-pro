﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeAgentcreateQueryResponse.
    /// </summary>
    public class AlipayOpenPublicLifeAgentcreateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 只有审核通过，且商户在支付宝发送的授权邮件中确认授权，此时生活号才会正式创建，查询才会返回该值
        /// </summary>
        [JsonPropertyName("life_app_id")]
        public string LifeAppId { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 支付宝商户入驻申请单状态，申请单状态包括：暂存、审核中、待商户确认、成功、失败。 说明：暂存是审核前的中间状态，如出现暂存状态请再次提交代创建生活号申请。
        /// </summary>
        [JsonPropertyName("order_status_biz_desc")]
        public string OrderStatusBizDesc { get; set; }

        /// <summary>
        /// 由开发者创建的外部入驻申请单据号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 只有审核失败才会返回该值
        /// </summary>
        [JsonPropertyName("refused_reason")]
        public string RefusedReason { get; set; }
    }
}
