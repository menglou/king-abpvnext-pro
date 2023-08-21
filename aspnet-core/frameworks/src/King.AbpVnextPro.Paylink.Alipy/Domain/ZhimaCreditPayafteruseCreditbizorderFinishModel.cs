﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditbizorderFinishModel Data Structure.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditbizorderFinishModel : AlipayObject
    {
        /// <summary>
        /// 芝麻后付订单号
        /// </summary>
        [JsonPropertyName("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 用户此订单是否守约
        /// </summary>
        [JsonPropertyName("is_fulfilled")]
        public string IsFulfilled { get; set; }

        /// <summary>
        /// 商户外部请求号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户对本次操作的附言描述
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }
    }
}
