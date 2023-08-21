using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppXwbtestabcQueryResponse.
    /// </summary>
    public class AlipayOpenAppXwbtestabcQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("xw")]
        public string Xw { get; set; }
    }
}
