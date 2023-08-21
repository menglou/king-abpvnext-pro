﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// InsMktCouponCmpgnBaseDTO Data Structure.
    /// </summary>
    public class InsMktCouponCmpgnBaseDTO : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [JsonPropertyName("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 权益盖帽值
        /// </summary>
        [JsonPropertyName("coupon_upper_value")]
        public string CouponUpperValue { get; set; }

        /// <summary>
        /// 权益值
        /// </summary>
        [JsonPropertyName("coupon_value")]
        public string CouponValue { get; set; }
    }
}
