using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrderCancelModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotDapplyOrderCancelModel : AlipayObject
    {
        /// <summary>
        /// 物料申请单号
        /// </summary>
        [JsonPropertyName("asset_apply_order_id")]
        public string AssetApplyOrderId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }
    }
}
