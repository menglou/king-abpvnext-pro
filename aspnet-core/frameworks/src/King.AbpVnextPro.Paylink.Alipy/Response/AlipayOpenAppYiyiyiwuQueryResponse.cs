using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppYiyiyiwuQueryResponse.
    /// </summary>
    public class AlipayOpenAppYiyiyiwuQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 12
        /// </summary>
        [JsonPropertyName("chucan")]
        public string Chucan { get; set; }
    }
}
