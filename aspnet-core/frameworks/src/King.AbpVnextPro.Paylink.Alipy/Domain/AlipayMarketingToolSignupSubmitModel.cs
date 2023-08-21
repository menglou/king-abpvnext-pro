using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingToolSignupSubmitModel Data Structure.
    /// </summary>
    public class AlipayMarketingToolSignupSubmitModel : AlipayObject
    {
        /// <summary>
        /// 玩法ID。
        /// </summary>
        [JsonPropertyName("play_id")]
        public string PlayId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
