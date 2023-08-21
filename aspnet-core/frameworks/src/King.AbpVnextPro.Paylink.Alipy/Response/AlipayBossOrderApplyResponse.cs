using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossOrderApplyResponse.
    /// </summary>
    public class AlipayBossOrderApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 订单信息
        /// </summary>
        [JsonPropertyName("order_info")]
        public string OrderInfo { get; set; }
    }
}
