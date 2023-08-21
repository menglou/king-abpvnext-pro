using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyQrcodeInvalidDeleteModel Data Structure.
    /// </summary>
    public class MybankCreditLoanapplyQrcodeInvalidDeleteModel : AlipayObject
    {
        /// <summary>
        /// 需要失效的二维码的加密 token 信息
        /// </summary>
        [JsonPropertyName("encrypt_token")]
        public string EncryptToken { get; set; }
    }
}
