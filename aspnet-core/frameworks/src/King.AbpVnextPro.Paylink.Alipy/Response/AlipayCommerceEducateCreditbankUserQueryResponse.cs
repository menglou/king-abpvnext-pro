using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateCreditbankUserQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCreditbankUserQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 学分银行id
        /// </summary>
        [JsonPropertyName("cb_id")]
        public string CbId { get; set; }
    }
}
