using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdUserMatchResponse.
    /// </summary>
    public class AlipayCommerceTransportAdUserMatchResponse : AlipayResponse
    {
        /// <summary>
        /// 广告投放端用户ID
        /// </summary>
        [JsonPropertyName("ad_user_id")]
        public string AdUserId { get; set; }
    }
}
