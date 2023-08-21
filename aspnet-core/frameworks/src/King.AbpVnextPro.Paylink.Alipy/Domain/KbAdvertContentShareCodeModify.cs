﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KbAdvertContentShareCodeModify Data Structure.
    /// </summary>
    public class KbAdvertContentShareCodeModify : AlipayObject
    {
        /// <summary>
        /// 宣传展示标题（不能超过30个字符）
        /// </summary>
        [JsonPropertyName("display_title")]
        public string DisplayTitle { get; set; }
    }
}
