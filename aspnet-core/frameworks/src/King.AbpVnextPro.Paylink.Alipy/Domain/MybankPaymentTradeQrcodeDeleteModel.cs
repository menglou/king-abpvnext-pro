using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MybankPaymentTradeQrcodeDeleteModel Data Structure.
    /// </summary>
    public class MybankPaymentTradeQrcodeDeleteModel : AlipayObject
    {
        /// <summary>
        /// 加密token
        /// </summary>
        [JsonPropertyName("encrypt_token")]
        public string EncryptToken { get; set; }
    }
}
