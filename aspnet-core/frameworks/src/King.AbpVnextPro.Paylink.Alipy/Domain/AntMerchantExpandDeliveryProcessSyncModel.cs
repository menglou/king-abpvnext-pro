using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandDeliveryProcessSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandDeliveryProcessSyncModel : AlipayObject
    {
        /// <summary>
        /// 发货计划反馈信息
        /// </summary>
        [JsonPropertyName("asset_delivery_process_info")]
        public AssetDeliveryProcessInfo AssetDeliveryProcessInfo { get; set; }
    }
}
