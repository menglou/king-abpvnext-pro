using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// StockQuantity Data Structure.
    /// </summary>
    public class StockQuantity : AlipayObject
    {
        /// <summary>
        /// 日期
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 库存量
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }
    }
}
