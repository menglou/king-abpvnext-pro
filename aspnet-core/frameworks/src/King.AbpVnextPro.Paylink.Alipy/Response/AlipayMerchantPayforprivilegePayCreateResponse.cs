using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePayCreateResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegePayCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 用于唤起资金授权支付的orderStr参数
        /// </summary>
        [JsonPropertyName("order_str")]
        public string OrderStr { get; set; }
    }
}
