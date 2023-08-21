using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandTradeorderSyncResponse.
    /// </summary>
    public class AntMerchantExpandTradeorderSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 订单创建成功后返回的id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
