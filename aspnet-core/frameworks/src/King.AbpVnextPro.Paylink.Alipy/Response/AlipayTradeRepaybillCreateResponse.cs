using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayTradeRepaybillCreateResponse.
    /// </summary>
    public class AlipayTradeRepaybillCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝账单编号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }
    }
}
