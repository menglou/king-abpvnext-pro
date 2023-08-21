using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetreverseCompleteSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandAssetreverseCompleteSyncModel : AlipayObject
    {
        /// <summary>
        /// 取消订单或退货成功入参
        /// </summary>
        [JsonPropertyName("asset_reverse_details")]
        public List<AssetReverseDetail> AssetReverseDetails { get; set; }
    }
}
