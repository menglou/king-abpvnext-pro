using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffProduceorderBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiSalesKbassetStuffProduceorderBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 每页容量：最小1，最大100
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }
    }
}
