﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZhimaCreditEpFreedepositApplyModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpFreedepositApplyModel : AlipayObject
    {
        /// <summary>
        /// 商户业务流水号，由商户生成，每次业务唯一。
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 完成免押额度业务之后，回跳商户地址。如果没有传入，使用配置的默认地址。
        /// </summary>
        [JsonPropertyName("merchant_url")]
        public string MerchantUrl { get; set; }

        /// <summary>
        /// 业务流水号，由芝麻生成，每次业务保证唯一。
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
