using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectruleCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesProjectruleCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonPropertyName("project_id")]
        public string ProjectId { get; set; }
    }
}
