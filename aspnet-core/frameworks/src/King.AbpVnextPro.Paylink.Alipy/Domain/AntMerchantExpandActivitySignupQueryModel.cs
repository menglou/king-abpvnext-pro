﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandActivitySignupQueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandActivitySignupQueryModel : AlipayObject
    {
        /// <summary>
        /// 参数名：活动标识  应用场景：天猫小二帮某商家报名活动  如何获取：该活动code需要由活动中心新增活动后运营提供给天猫。
        /// </summary>
        [JsonPropertyName("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 报名信息扩展字段,可为空，具体传参由开发约定
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }
    }
}
