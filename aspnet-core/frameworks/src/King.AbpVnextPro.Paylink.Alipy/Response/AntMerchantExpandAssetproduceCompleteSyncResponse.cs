﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandAssetproduceCompleteSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetproduceCompleteSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 物料订单更新结果信息
        /// </summary>
        [JsonPropertyName("asset_results")]
        public List<AssetResult> AssetResults { get; set; }
    }
}
