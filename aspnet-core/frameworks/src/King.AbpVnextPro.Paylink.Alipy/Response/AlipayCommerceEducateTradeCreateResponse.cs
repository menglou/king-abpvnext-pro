using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateTradeCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateTradeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("edu_trade_no")]
        public string EduTradeNo { get; set; }
    }
}
