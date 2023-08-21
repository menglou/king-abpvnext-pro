using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayAssetCardTransferResponse.
    /// </summary>
    public class AlipayAssetCardTransferResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝订单id
        /// </summary>
        [JsonPropertyName("asset_order_id")]
        public string AssetOrderId { get; set; }
    }
}
