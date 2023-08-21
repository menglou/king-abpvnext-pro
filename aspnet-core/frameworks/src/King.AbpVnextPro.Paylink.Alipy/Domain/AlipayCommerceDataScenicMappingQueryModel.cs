using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceDataScenicMappingQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceDataScenicMappingQueryModel : AlipayObject
    {
        /// <summary>
        /// 景区审核信息查询请求。 集合长度不能超过200
        /// </summary>
        [JsonPropertyName("scenic_audit_query_req")]
        public List<ScenicAuditQueryReq> ScenicAuditQueryReq { get; set; }
    }
}
