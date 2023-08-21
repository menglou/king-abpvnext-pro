﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// BuyerNotesInfo Data Structure.
    /// </summary>
    public class BuyerNotesInfo : AlipayObject
    {
        /// <summary>
        /// 标题下的描述列表，列表类型，每项不得为空,最多10项，总长度不能超过2600个中文字符
        /// </summary>
        [JsonPropertyName("details")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 描述标题，不得超过15个中文字符
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
