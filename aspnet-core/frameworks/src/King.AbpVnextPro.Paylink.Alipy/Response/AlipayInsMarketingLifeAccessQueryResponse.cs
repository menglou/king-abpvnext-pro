using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsMarketingLifeAccessQueryResponse.
    /// </summary>
    public class AlipayInsMarketingLifeAccessQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [JsonPropertyName("access")]
        public bool Access { get; set; }
    }
}
