using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorRolerelationBindResponse.
    /// </summary>
    public class KoubeiMerchantOperatorRolerelationBindResponse : AlipayResponse
    {
        /// <summary>
        /// 操作是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
