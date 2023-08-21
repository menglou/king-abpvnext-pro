using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppInvoiceApplyResponse.
    /// </summary>
    public class AlipayEbppInvoiceApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝返回的发票申请id,该id具有唯一性
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }
    }
}
