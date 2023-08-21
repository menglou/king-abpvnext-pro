using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherStockQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingVoucherStockQueryModel : AlipayObject
    {
        /// <summary>
        /// 库存ID, 库存创建接口返回
        /// </summary>
        [JsonPropertyName("stock_id")]
        public string StockId { get; set; }
    }
}
