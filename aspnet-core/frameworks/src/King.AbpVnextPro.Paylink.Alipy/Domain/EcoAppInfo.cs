using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// EcoAppInfo Data Structure.
    /// </summary>
    public class EcoAppInfo : AlipayObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [JsonPropertyName("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }
    }
}
