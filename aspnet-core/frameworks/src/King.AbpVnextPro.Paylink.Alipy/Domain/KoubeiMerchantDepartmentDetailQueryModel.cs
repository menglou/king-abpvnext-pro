using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMerchantDepartmentDetailQueryModel Data Structure.
    /// </summary>
    public class KoubeiMerchantDepartmentDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 人员管理场景的部门id
        /// </summary>
        [JsonPropertyName("dept_id")]
        public string DeptId { get; set; }
    }
}
