﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetinfoSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandAssetinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 传入需要反馈的物料信息对象列表.
        /// </summary>
        [JsonPropertyName("asset_infos")]
        public List<AssetInfoItem> AssetInfos { get; set; }
    }
}
