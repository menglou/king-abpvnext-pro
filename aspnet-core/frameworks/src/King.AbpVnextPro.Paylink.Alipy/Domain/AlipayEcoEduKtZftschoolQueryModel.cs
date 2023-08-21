﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoEduKtZftschoolQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoEduKtZftschoolQueryModel : AlipayObject
    {
        /// <summary>
        /// 进件单号id，进件接口返回
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// ISV的支付宝唯一标识PID
        /// </summary>
        [JsonPropertyName("partner_pid")]
        public string PartnerPid { get; set; }
    }
}
