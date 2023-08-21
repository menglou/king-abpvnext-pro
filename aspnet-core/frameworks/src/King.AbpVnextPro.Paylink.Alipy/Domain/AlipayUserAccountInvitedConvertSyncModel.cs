﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserAccountInvitedConvertSyncModel Data Structure.
    /// </summary>
    public class AlipayUserAccountInvitedConvertSyncModel : AlipayObject
    {
        /// <summary>
        /// 转化标签
        /// </summary>
        [JsonPropertyName("convert_tag")]
        public string ConvertTag { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
