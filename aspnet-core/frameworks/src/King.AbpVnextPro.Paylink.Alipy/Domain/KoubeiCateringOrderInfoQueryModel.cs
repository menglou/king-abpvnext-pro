using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringOrderInfoQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringOrderInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
