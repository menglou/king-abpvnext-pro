using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingDecodeData Data Structure.
    /// </summary>
    public class AlipayMarketingDecodeData : AlipayObject
    {
        /// <summary>
        /// 钱包二维码码值
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }
    }
}
