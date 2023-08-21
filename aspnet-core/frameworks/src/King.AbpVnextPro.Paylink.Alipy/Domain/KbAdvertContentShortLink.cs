using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KbAdvertContentShortLink Data Structure.
    /// </summary>
    public class KbAdvertContentShortLink : AlipayObject
    {
        /// <summary>
        /// 链接地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
