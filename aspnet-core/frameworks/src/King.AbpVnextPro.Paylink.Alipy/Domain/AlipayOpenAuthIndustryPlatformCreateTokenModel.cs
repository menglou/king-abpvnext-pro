using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAuthIndustryPlatformCreateTokenModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthIndustryPlatformCreateTokenModel : AlipayObject
    {
        /// <summary>
        /// isv的appid
        /// </summary>
        [JsonPropertyName("isv_appid")]
        public string IsvAppid { get; set; }

        /// <summary>
        /// auth_mycar_violation
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }
    }
}
