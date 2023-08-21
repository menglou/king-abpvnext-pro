using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorRoleDeleteModel Data Structure.
    /// </summary>
    public class KoubeiMerchantOperatorRoleDeleteModel : AlipayObject
    {
        /// <summary>
        /// 操作员ID
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [JsonPropertyName("role_id")]
        public string RoleId { get; set; }
    }
}
