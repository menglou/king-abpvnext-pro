using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossFncGfacceptanceDetailQueryResponse.
    /// </summary>
    public class AlipayBossFncGfacceptanceDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业财受理详情查询结果
        /// </summary>
        [JsonPropertyName("result")]
        public GFAOpenAPIDetailQueryResult Result { get; set; }
    }
}
