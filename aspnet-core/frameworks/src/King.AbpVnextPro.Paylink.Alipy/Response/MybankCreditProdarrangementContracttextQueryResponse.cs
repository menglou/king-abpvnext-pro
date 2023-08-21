using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankCreditProdarrangementContracttextQueryResponse.
    /// </summary>
    public class MybankCreditProdarrangementContracttextQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 合同内容
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
