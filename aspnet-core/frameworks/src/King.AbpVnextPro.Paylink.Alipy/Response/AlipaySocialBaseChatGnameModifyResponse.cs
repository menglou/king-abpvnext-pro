using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGnameModifyResponse.
    /// </summary>
    public class AlipaySocialBaseChatGnameModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 修改结果
        /// </summary>
        [JsonPropertyName("result_modify")]
        public bool ResultModify { get; set; }
    }
}
