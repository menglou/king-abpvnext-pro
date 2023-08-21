using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiTradeKbdeliveryDeliveryCancelResponse.
    /// </summary>
    public class KoubeiTradeKbdeliveryDeliveryCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 成功关闭时间，时间格式:  yyyyMMddHHmmss
        /// </summary>
        [JsonPropertyName("gmt_close")]
        public string GmtClose { get; set; }

        /// <summary>
        /// 口碑物流单号
        /// </summary>
        [JsonPropertyName("logistics_order_no")]
        public string LogisticsOrderNo { get; set; }
    }
}
