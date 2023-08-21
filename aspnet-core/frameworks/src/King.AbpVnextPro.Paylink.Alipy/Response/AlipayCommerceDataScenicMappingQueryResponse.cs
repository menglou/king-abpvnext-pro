using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceDataScenicMappingQueryResponse.
    /// </summary>
    public class AlipayCommerceDataScenicMappingQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 景区审核信息查询结果
        /// </summary>
        [JsonPropertyName("scenic_audit_response")]
        public ScenicAuditResponse ScenicAuditResponse { get; set; }
    }
}
