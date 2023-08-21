using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryResponse.
    /// </summary>
    public class AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 10
        /// </summary>
        [JsonPropertyName("userid")]
        public string Userid { get; set; }
    }
}
