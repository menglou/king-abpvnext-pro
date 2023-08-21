using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ExtTemplateConf Data Structure.
    /// </summary>
    public class ExtTemplateConf : AlipayObject
    {
        /// <summary>
        /// 淘宝uid
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 先享后买id
        /// </summary>
        [JsonPropertyName("xxhm_info_id")]
        public string XxhmInfoId { get; set; }
    }
}
