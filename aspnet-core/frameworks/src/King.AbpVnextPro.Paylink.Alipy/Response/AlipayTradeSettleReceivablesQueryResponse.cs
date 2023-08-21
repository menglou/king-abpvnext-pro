using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayTradeSettleReceivablesQueryResponse.
    /// </summary>
    public class AlipayTradeSettleReceivablesQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 待结算金额，人民币，单位为元
        /// </summary>
        [JsonPropertyName("unsettled_amount")]
        public string UnsettledAmount { get; set; }
    }
}
