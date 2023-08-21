using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTitleDynamicGetModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceTitleDynamicGetModel : AlipayObject
    {
        /// <summary>
        /// 抬头动态码
        /// </summary>
        [JsonPropertyName("bar_code")]
        public string BarCode { get; set; }
    }
}
