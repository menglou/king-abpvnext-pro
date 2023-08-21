﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// SsdataDataserviceMetainfoSyncModel Data Structure.
    /// </summary>
    public class SsdataDataserviceMetainfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 元数据信息
        /// </summary>
        [JsonPropertyName("meta_info")]
        public string MetaInfo { get; set; }
    }
}
