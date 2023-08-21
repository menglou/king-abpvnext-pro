using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTopregisterRegisterCreateModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceTopregisterRegisterCreateModel : AlipayObject
    {
        /// <summary>
        /// 创建工单请求
        /// </summary>
        [JsonPropertyName("create_request")]
        public InvoiceRegisterCreateDTO CreateRequest { get; set; }
    }
}
