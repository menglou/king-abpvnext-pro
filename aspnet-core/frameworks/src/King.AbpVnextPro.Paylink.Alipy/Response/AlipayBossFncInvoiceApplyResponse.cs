using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossFncInvoiceApplyResponse.
    /// </summary>
    public class AlipayBossFncInvoiceApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 开票申请ID，唯一性ID
        /// </summary>
        [JsonPropertyName("result_set")]
        public string ResultSet { get; set; }
    }
}
