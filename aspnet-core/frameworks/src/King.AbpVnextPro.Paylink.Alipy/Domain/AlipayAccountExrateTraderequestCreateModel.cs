using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayAccountExrateTraderequestCreateModel Data Structure.
    /// </summary>
    public class AlipayAccountExrateTraderequestCreateModel : AlipayObject
    {
        /// <summary>
        /// 交易请求对象内容
        /// </summary>
        [JsonPropertyName("trade_request")]
        public TradeRequestVO TradeRequest { get; set; }
    }
}
