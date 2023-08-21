using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayFundTransPayeeBindQueryModel Data Structure.
    /// </summary>
    public class AlipayFundTransPayeeBindQueryModel : AlipayObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [JsonPropertyName("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 证件类型,暂仅支持 IDENTITY_CARD （身份证）
        /// </summary>
        [JsonPropertyName("identity_type")]
        public string IdentityType { get; set; }
    }
}
