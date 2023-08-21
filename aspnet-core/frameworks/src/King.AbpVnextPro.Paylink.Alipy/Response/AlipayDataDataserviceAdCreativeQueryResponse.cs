using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 创意详情
        /// </summary>
        [JsonPropertyName("creative_detail")]
        public CreativeDetail CreativeDetail { get; set; }
    }
}
