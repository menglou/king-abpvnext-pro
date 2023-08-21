using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingToolSignupQueryResponse.
    /// </summary>
    public class AlipayMarketingToolSignupQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动ID。
        /// </summary>
        [JsonPropertyName("play_id")]
        public string PlayId { get; set; }

        /// <summary>
        /// 是否已经报名。
        /// </summary>
        [JsonPropertyName("sign_up")]
        public bool SignUp { get; set; }
    }
}
