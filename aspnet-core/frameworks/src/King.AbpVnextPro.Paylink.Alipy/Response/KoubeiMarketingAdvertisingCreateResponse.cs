using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingAdvertisingCreateResponse.
    /// </summary>
    public class KoubeiMarketingAdvertisingCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建广告唯一标识
        /// </summary>
        [JsonPropertyName("ad_id")]
        public string AdId { get; set; }
    }
}
