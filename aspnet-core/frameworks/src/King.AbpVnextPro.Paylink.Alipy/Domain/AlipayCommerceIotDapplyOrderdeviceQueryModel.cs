using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrderdeviceQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotDapplyOrderdeviceQueryModel : AlipayObject
    {
        /// <summary>
        /// 进件申请单号
        /// </summary>
        [JsonPropertyName("apply_order_id")]
        public string ApplyOrderId { get; set; }
    }
}
