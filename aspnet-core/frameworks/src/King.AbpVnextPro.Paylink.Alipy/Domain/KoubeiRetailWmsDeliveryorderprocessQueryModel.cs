using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiRetailWmsDeliveryorderprocessQueryModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsDeliveryorderprocessQueryModel : AlipayObject
    {
        /// <summary>
        /// 通知单id
        /// </summary>
        [JsonPropertyName("notice_order_id")]
        public string NoticeOrderId { get; set; }
    }
}
