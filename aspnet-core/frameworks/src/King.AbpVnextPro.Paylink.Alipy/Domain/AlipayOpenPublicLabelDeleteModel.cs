using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenPublicLabelDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicLabelDeleteModel : AlipayObject
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
