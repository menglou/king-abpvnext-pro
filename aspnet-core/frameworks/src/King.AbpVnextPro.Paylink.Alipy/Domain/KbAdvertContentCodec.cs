using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KbAdvertContentCodec Data Structure.
    /// </summary>
    public class KbAdvertContentCodec : AlipayObject
    {
        /// <summary>
        /// 二维码广告内容
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
