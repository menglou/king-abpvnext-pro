using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserCharityForestQueryResponse.
    /// </summary>
    public class AlipayUserCharityForestQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否开通了蚂蚁森林
        /// </summary>
        [JsonPropertyName("forest_user")]
        public bool ForestUser { get; set; }
    }
}
