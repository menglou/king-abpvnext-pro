using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetproduceCompleteSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandAssetproduceCompleteSyncModel : AlipayObject
    {
        /// <summary>
        /// 物料生产单完成后指定物流信息
        /// </summary>
        [JsonPropertyName("asset_produce_details")]
        public List<ItemDeliveryDetail> AssetProduceDetails { get; set; }
    }
}
