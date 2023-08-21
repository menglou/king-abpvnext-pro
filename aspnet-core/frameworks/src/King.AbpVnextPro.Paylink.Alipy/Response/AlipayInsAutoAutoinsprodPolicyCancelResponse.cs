using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodPolicyCancelResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodPolicyCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 操作结果 true/false
        /// </summary>
        [JsonPropertyName("cancel_result")]
        public string CancelResult { get; set; }
    }
}
