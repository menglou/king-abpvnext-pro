using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ScenicAuditResponse Data Structure.
    /// </summary>
    public class ScenicAuditResponse : AlipayObject
    {
        /// <summary>
        /// 景区审核信息查询结果
        /// </summary>
        [JsonPropertyName("scenic_audit_info")]
        public List<ScenicAuditInfo> ScenicAuditInfo { get; set; }
    }
}
