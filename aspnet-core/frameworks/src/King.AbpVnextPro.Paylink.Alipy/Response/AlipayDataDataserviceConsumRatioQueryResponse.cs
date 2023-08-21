using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceConsumRatioQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceConsumRatioQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 占比数据接口返回数据结构
        /// </summary>
        [JsonPropertyName("ratio_detail")]
        public RatioDetail RatioDetail { get; set; }
    }
}
