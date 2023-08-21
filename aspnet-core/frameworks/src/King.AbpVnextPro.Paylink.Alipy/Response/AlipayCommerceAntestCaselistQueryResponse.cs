using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceAntestCaselistQueryResponse.
    /// </summary>
    public class AlipayCommerceAntestCaselistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用例列表JSONString
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
