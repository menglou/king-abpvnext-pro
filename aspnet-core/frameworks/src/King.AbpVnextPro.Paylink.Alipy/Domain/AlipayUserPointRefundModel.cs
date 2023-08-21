﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserPointRefundModel Data Structure.
    /// </summary>
    public class AlipayUserPointRefundModel : AlipayObject
    {
        /// <summary>
        /// 业务大类，与调用扣减积分接口时传入的值一致。
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务流水号，用来映射需要回退积分的订单号，与调用扣减积分接口时传入的值一致。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务子类型，与调用扣减积分接口时传入的值一致。
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 订单所属支付宝用户的uid，与调用扣减积分接口时传入的值一致。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
