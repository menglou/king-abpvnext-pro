﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserAliyunbenefitRefundModel Data Structure.
    /// </summary>
    public class AlipayUserAliyunbenefitRefundModel : AlipayObject
    {
        /// <summary>
        /// 业务回传信息，值是json格式字符串，阿里云会对回传的key强管控，但不理解value内容，目前支持的回传key只有一个：requestSourceInfo，后续若有新增需同步更新api文档
        /// </summary>
        [JsonPropertyName("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 业务流水号，用来映射需要回退积分的订单号，与权益兑换时传入的值一致。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 订单所属支付宝用户的uid，与兑换接口中传入的值保持一致
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
