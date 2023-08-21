using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMallScanpurchasePreorderCancelModel Data Structure.
    /// </summary>
    public class KoubeiMallScanpurchasePreorderCancelModel : AlipayObject
    {
        /// <summary>
        /// 预订单编号
        /// </summary>
        [JsonPropertyName("advance_order_id")]
        public string AdvanceOrderId { get; set; }
    }
}
