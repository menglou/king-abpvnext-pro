using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenPublicLabelCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicLabelCreateModel : AlipayObject
    {
        /// <summary>
        /// 标签名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
