﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampCreateModel : AlipayObject
    {
        /// <summary>
        /// 单用户以支付宝账号维度可参与当前营销活动的总次数，由开发者自定义此数值
        /// </summary>
        [JsonPropertyName("account_count")]
        public string AccountCount { get; set; }

        /// <summary>
        /// 以移动设备维度可参与当前营销活动的总次数，由开发者自定义此数值
        /// </summary>
        [JsonPropertyName("appid_count")]
        public string AppidCount { get; set; }

        /// <summary>
        /// 单个用户当前活动允许中奖的最大次数，最大值999999
        /// </summary>
        [JsonPropertyName("award_count")]
        public string AwardCount { get; set; }

        /// <summary>
        /// 活动奖品总中奖几率，开发者需传入整数值，如：传入99支付宝默认为99%
        /// </summary>
        [JsonPropertyName("award_rate")]
        public string AwardRate { get; set; }

        /// <summary>
        /// 活动唯一标识,不能包含除中文、英文、数字以外的字符，创建后不能修改，需要保证在商户端不重复。
        /// </summary>
        [JsonPropertyName("camp_code")]
        public string CampCode { get; set; }

        /// <summary>
        /// 活动结束时间，yyyy-MM-dd HH:00:00格式(到小时)，需要大于活动开始时间
        /// </summary>
        [JsonPropertyName("camp_end_time")]
        public string CampEndTime { get; set; }

        /// <summary>
        /// 活动名称，开发者自定义
        /// </summary>
        [JsonPropertyName("camp_name")]
        public string CampName { get; set; }

        /// <summary>
        /// 活动开始时间，yyyy-MM-dd HH:00:00格式（到小时），时间不能早于当前日期的0点
        /// </summary>
        [JsonPropertyName("camp_start_time")]
        public string CampStartTime { get; set; }

        /// <summary>
        /// 凭证验证规则id，通过alipay.marketing.campaign.cert.create 接口创建的凭证id
        /// </summary>
        [JsonPropertyName("cert_rule_id")]
        public string CertRuleId { get; set; }

        /// <summary>
        /// 单用户以账户证件号（如身份证号、护照、军官证等）维度可参与当前营销活动的总次数，由开发者自定义此数值
        /// </summary>
        [JsonPropertyName("certification_count")]
        public string CertificationCount { get; set; }

        /// <summary>
        /// 圈人规则id，通过alipay.marketing.campaign.rule.crowd.create 接口创建的规则id
        /// </summary>
        [JsonPropertyName("crowd_rule_id")]
        public string CrowdRuleId { get; set; }

        /// <summary>
        /// 以认证手机号（与支付宝账号绑定的手机号）维度的可参与当前营销活动的总次数，由开发者自定义此数值
        /// </summary>
        [JsonPropertyName("mobile_count")]
        public string MobileCount { get; set; }

        /// <summary>
        /// 开发者用于区分商户的唯一标识，由开发者自定义，用于区分是开发者名下哪一个商户的请求，为空则为默认标识
        /// </summary>
        [JsonPropertyName("mpid")]
        public string Mpid { get; set; }

        /// <summary>
        /// 奖品模型，至少需要配置一个奖品
        /// </summary>
        [JsonPropertyName("prize_list")]
        public List<MpPrizeInfoModel> PrizeList { get; set; }

        /// <summary>
        /// 营销验证规则id，由支付宝配置
        /// </summary>
        [JsonPropertyName("promo_rule_id")]
        public string PromoRuleId { get; set; }

        /// <summary>
        /// 活动触发类型，目前支持  CAMP_USER_TRIGGER：用户触发（开发者调用alipay.marketing.campaign.drawcamp.trigger 接口触发）；  CAMP_SYS_TRIGGER：系统触发，必须配置实时人群验证规则（如：配置了监听用户支付事件，支付宝会根据活动规则自动发奖，无需用户手动触发）。
        /// </summary>
        [JsonPropertyName("trigger_type")]
        public string TriggerType { get; set; }

        /// <summary>
        /// 实时人群验证规则id，由支付宝配置
        /// </summary>
        [JsonPropertyName("trigger_user_rule_id")]
        public string TriggerUserRuleId { get; set; }

        /// <summary>
        /// 人群验证规则id，由支付宝配置
        /// </summary>
        [JsonPropertyName("user_rule_id")]
        public string UserRuleId { get; set; }
    }
}
