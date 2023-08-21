﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// BenefitGradeConfig Data Structure.
    /// </summary>
    public class BenefitGradeConfig : AlipayObject
    {
        /// <summary>
        /// 权益背景图片地址，若没有，可以先mock一个地址进行填写
        /// </summary>
        [JsonPropertyName("background_url")]
        public string BackgroundUrl { get; set; }

        /// <summary>
        /// 该等级下权益的介绍
        /// </summary>
        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 用户等级，差异化时可填primary、golden、platinum、diamond，非差异化时可填common
        /// </summary>
        [JsonPropertyName("grade")]
        public string Grade { get; set; }

        /// <summary>
        /// 权益关联的活动页面
        /// </summary>
        [JsonPropertyName("page_url")]
        public string PageUrl { get; set; }

        /// <summary>
        /// 当前等级兑换权益所需要消耗的积分
        /// </summary>
        [JsonPropertyName("point")]
        public long Point { get; set; }

        /// <summary>
        /// 该等级兑换权益时，消耗的积分需要乘以配置的这个折扣，进行优惠
        /// </summary>
        [JsonPropertyName("point_discount")]
        public string PointDiscount { get; set; }
    }
}
