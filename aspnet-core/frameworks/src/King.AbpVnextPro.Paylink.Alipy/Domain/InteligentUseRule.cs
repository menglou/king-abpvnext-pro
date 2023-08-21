﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// InteligentUseRule Data Structure.
    /// </summary>
    public class InteligentUseRule : AlipayObject
    {
        /// <summary>
        /// 券的不可用时间
        /// </summary>
        [JsonPropertyName("inteligent_forbidden_time")]
        public InteligentForbiddenTime InteligentForbiddenTime { get; set; }

        /// <summary>
        /// 券可用时间段
        /// </summary>
        [JsonPropertyName("inteligent_use_times")]
        public List<InteligentUseTime> InteligentUseTimes { get; set; }

        /// <summary>
        /// 优惠券的使用支付渠道限制规  则，  不受支付渠道限制  :USE_NO_LIMIT;  仅限口碑储值卡支付时可用  :USE_ON_CURRENT_PAY_C  HANNEL;  口碑储值卡支付时不可用  :NOT_ALLOWED_USE;  【备注】支付渠道限制不允许修改
        /// </summary>
        [JsonPropertyName("limit_rule")]
        public string LimitRule { get; set; }

        /// <summary>
        /// 券核销的最低消费门槛，单位元
        /// </summary>
        [JsonPropertyName("min_consume")]
        public string MinConsume { get; set; }

        /// <summary>
        /// 核券门槛-最低消费金额-推荐约束；  提供推荐方案参数可调区间范围, 为空则认为不可调
        /// </summary>
        [JsonPropertyName("min_consume_condition")]
        public InteligentDataCondition MinConsumeCondition { get; set; }

        /// <summary>
        /// 券买单跳转链接
        /// </summary>
        [JsonPropertyName("pay_redirect_url")]
        public string PayRedirectUrl { get; set; }

        /// <summary>
        /// 券适用门店列表  仅品牌商发起的招商活动可为空  直发奖类型活动必须与活动适用门店一致  最多支持10w家门店
        /// </summary>
        [JsonPropertyName("suit_shops")]
        public List<string> SuitShops { get; set; }
    }
}
