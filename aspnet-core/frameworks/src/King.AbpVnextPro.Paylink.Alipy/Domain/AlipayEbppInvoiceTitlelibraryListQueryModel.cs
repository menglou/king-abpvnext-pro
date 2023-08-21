using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTitlelibraryListQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceTitlelibraryListQueryModel : AlipayObject
    {
        /// <summary>
        /// 模糊查询的抬头名称
        /// </summary>
        [JsonPropertyName("title_simple_name")]
        public string TitleSimpleName { get; set; }
    }
}
