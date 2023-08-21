﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// InsMktCouponBaseDTO Data Structure.
    /// </summary>
    public class InsMktCouponBaseDTO : AlipayObject
    {
        /// <summary>
        /// 权益Id
        /// </summary>
        [JsonPropertyName("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [JsonPropertyName("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 权益值
        /// </summary>
        [JsonPropertyName("coupon_value")]
        public string CouponValue { get; set; }
    }
}
