﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenPublicAdvertCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicAdvertCreateModel : AlipayObject
    {
        /// <summary>
        ///  广告位轮播内容列表。数量限制：大于1个，小于5个。广告位轮播内容顺序：与接口传入的顺序排列一致。
        /// </summary>
        [JsonPropertyName("advert_items")]
        public List<AdvertItem> AdvertItems { get; set; }
    }
}
