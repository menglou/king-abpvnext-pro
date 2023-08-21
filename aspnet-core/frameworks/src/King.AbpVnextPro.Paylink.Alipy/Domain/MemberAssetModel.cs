﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MemberAssetModel Data Structure.
    /// </summary>
    public class MemberAssetModel : AlipayObject
    {
        /// <summary>
        /// 权益类型，目前只支持2种。  BALANCE：金额   POINT：积分
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
