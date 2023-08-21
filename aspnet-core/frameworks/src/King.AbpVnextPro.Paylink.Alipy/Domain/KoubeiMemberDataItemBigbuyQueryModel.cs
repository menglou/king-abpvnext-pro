﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMemberDataItemBigbuyQueryModel Data Structure.
    /// </summary>
    public class KoubeiMemberDataItemBigbuyQueryModel : AlipayObject
    {
        /// <summary>
        /// 城市编码，国标码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 纬度，当城市id未传时用来获取对应城市id
        /// </summary>
        [JsonPropertyName("latitude")]
        public long Latitude { get; set; }

        /// <summary>
        /// 经度，当城市id未传时用来获取对应城市id
        /// </summary>
        [JsonPropertyName("longitude")]
        public long Longitude { get; set; }

        /// <summary>
        /// 展位码，如果有放置展位需求的话，用于请求cdp查询对应展位
        /// </summary>
        [JsonPropertyName("space_code_list")]
        public List<string> SpaceCodeList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
