using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsMarketingExperienceAccountQueryModel Data Structure.
    /// </summary>
    public class AlipayInsMarketingExperienceAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 用户2088
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
