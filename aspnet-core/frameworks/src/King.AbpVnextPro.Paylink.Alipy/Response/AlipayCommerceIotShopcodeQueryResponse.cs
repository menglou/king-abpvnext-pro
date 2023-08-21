using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotShopcodeQueryResponse.
    /// </summary>
    public class AlipayCommerceIotShopcodeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 投放状态，已投放（on），未投放（off）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
