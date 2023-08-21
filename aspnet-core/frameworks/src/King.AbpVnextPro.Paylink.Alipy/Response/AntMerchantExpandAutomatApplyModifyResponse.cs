using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandAutomatApplyModifyResponse.
    /// </summary>
    public class AntMerchantExpandAutomatApplyModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝设备ID
        /// </summary>
        [JsonPropertyName("alipay_terminal_id")]
        public string AlipayTerminalId { get; set; }
    }
}
