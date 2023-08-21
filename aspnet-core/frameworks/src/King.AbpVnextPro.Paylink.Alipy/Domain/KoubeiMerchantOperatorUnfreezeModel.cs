using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorUnfreezeModel Data Structure.
    /// </summary>
    public class KoubeiMerchantOperatorUnfreezeModel : AlipayObject
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 操作员ID
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }
    }
}
