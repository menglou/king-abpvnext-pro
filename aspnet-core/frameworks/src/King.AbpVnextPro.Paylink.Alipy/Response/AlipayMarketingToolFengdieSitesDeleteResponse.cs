using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesDeleteResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 返回删除云凤蝶站点成功与失败的结果
        /// </summary>
        [JsonPropertyName("data")]
        public FengdieSuccessRespModel Data { get; set; }
    }
}
