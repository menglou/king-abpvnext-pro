using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 站点查询返回值
        /// </summary>
        [JsonPropertyName("data")]
        public FengdieSitesQueryRespModel Data { get; set; }
    }
}
