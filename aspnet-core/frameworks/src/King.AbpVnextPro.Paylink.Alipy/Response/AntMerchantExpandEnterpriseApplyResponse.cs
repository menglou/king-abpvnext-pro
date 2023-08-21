using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandEnterpriseApplyResponse.
    /// </summary>
    public class AntMerchantExpandEnterpriseApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝端商户入驻申请单据号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部入驻申请单据号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
