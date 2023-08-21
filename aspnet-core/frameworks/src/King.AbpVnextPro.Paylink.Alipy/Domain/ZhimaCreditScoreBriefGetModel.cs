﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZhimaCreditScoreBriefGetModel Data Structure.
    /// </summary>
    public class ZhimaCreditScoreBriefGetModel : AlipayObject
    {
        /// <summary>
        /// 350～950之间 业务判断的准入标准 建议业务确定一个稳定的判断标准 频繁的变更该标准可能导致接口被停用
        /// </summary>
        [JsonPropertyName("admittance_score")]
        public long AdmittanceScore { get; set; }

        /// <summary>
        /// 对应的证件号(未脱敏)或支付宝uid
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，目前支持枚举如下： * IDENTITY_CARD：身份证； * PASSPORT：护照； * ALIPAY_USER_ID：支付宝uid。
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 芝麻平台服务商模式下的二级商户标识，如果是直连商户调用该接口，不需要设置
        /// </summary>
        [JsonPropertyName("linked_merchant_id")]
        public string LinkedMerchantId { get; set; }

        /// <summary>
        /// 用户姓名 当证件类型为ALIPAY_USER_ID时不需要传入
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 产品码，固定为 w1010100000000002733。
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，64 位长度的字母、数字、下划线组合。 该标识作为对账的关键信息，商户要保证其唯一性，对于用户使用相同transaction_id的查询，芝麻在一天（86400秒）内返回首次查询数据，超过有效期的查询即为无效并返回异常，有效期内的重复查询不重新计费。
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
