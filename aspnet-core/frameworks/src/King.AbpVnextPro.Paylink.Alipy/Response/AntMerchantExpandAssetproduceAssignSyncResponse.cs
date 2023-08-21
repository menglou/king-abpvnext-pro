using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandAssetproduceAssignSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetproduceAssignSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 供应商处理生产指令结果
        /// </summary>
        [JsonPropertyName("asset_results")]
        public List<AssetResult> AssetResults { get; set; }
    }
}
