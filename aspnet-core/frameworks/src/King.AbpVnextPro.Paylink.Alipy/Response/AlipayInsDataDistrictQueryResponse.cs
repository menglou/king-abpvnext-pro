using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsDataDistrictQueryResponse.
    /// </summary>
    public class AlipayInsDataDistrictQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 地区信息
        /// </summary>
        [JsonPropertyName("districts")]
        public string Districts { get; set; }
    }
}
