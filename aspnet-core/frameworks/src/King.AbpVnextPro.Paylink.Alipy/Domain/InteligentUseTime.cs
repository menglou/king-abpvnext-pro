﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// InteligentUseTime Data Structure.
    /// </summary>
    public class InteligentUseTime : AlipayObject
    {
        /// <summary>
        /// 券可用时段时间维度，目前支持周(W)
        /// </summary>
        [JsonPropertyName("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 券可用时间段  可用时间段起止时间用逗号分隔，多个时间段之间用^分隔  如, "16:00:00,20:00:00^21:00:00,22:00:00"表示16点至20点，21点至22点可用  时间段不可重叠
        /// </summary>
        [JsonPropertyName("times")]
        public string Times { get; set; }

        /// <summary>
        /// 券可用时间维度值  周维度的取值范围1-7(周一至周日)，多个可用时段用逗号分隔  如"1,3,5"，对应周一，周三，周五可用
        /// </summary>
        [JsonPropertyName("values")]
        public string Values { get; set; }
    }
}
