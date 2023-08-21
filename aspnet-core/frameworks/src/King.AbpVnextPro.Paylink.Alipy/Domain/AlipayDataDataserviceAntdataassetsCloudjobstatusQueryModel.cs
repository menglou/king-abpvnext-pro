﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsCloudjobstatusQueryModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAntdataassetsCloudjobstatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 分区信息
        /// </summary>
        [JsonPropertyName("bizdate")]
        public string Bizdate { get; set; }

        /// <summary>
        /// ODPS表的guid
        /// </summary>
        [JsonPropertyName("guid")]
        public string Guid { get; set; }
    }
}
