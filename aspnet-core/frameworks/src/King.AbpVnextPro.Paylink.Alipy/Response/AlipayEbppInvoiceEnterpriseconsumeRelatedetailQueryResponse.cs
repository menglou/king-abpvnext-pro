using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeRelatedetailQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseconsumeRelatedetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 账单凭证关联信息
        /// </summary>
        [JsonPropertyName("expense_ctrl_consume_info")]
        public ExpenseCtrlConsumeInfo ExpenseCtrlConsumeInfo { get; set; }
    }
}
