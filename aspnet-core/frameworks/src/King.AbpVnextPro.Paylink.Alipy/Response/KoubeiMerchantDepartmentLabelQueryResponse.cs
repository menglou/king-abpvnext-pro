using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMerchantDepartmentLabelQueryResponse.
    /// </summary>
    public class KoubeiMerchantDepartmentLabelQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 人员组织可用的部门标签列表
        /// </summary>
        [JsonPropertyName("department_labels")]
        public List<DepartmentLabel> DepartmentLabels { get; set; }
    }
}
