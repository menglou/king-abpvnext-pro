using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTopregisterRegisterCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceTopregisterRegisterCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 工单ID
        /// </summary>
        [JsonPropertyName("register_id")]
        public string RegisterId { get; set; }
    }
}
