using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoEduKtBillingSendResponse.
    /// </summary>
    public class AlipayEcoEduKtBillingSendResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝－中小学－教育缴费的账单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
