using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingToolSignupSubmitResponse.
    /// </summary>
    public class AlipayMarketingToolSignupSubmitResponse : AlipayResponse
    {
        /// <summary>
        /// 玩法ID。
        /// </summary>
        [JsonPropertyName("play_id")]
        public string PlayId { get; set; }
    }
}
