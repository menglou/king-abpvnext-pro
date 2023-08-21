using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppXwbtstabcQueryResponse.
    /// </summary>
    public class AlipayOpenAppXwbtstabcQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("xwbbbdd")]
        public string Xwbbbdd { get; set; }
    }
}
