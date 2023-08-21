using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdGroupQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdGroupQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 单元详情
        /// </summary>
        [JsonPropertyName("group_detail")]
        public OuterGroup GroupDetail { get; set; }
    }
}
