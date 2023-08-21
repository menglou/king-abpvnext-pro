using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGinvSendResponse.
    /// </summary>
    public class AlipaySocialBaseChatGinvSendResponse : AlipayResponse
    {
        /// <summary>
        /// 结果提示信息
        /// </summary>
        [JsonPropertyName("result_tip")]
        public string ResultTip { get; set; }
    }
}
