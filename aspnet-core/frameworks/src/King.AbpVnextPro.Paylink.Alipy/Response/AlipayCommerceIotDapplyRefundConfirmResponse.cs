using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyRefundConfirmResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyRefundConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 物料申请单号
        /// </summary>
        [JsonPropertyName("asset_apply_order_id")]
        public string AssetApplyOrderId { get; set; }
    }
}
