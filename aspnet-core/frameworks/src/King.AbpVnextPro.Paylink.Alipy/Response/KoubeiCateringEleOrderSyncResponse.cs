using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringEleOrderSyncResponse.
    /// </summary>
    public class KoubeiCateringEleOrderSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 原始的订单id编号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
