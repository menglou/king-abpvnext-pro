﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// InsHealthGainFlowResult Data Structure.
    /// </summary>
    public class InsHealthGainFlowResult : AlipayObject
    {
        /// <summary>
        /// 业务类型。免费医疗金 HEALTH_BEAN_SIMPLE_UPGRADE、守护金 HEALTH_GUARDIAN_GOLD、多收多宝新门诊 HEALTH_DSDB_NEW_OUTPATIENT
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 入口
        /// </summary>
        [JsonPropertyName("entrance")]
        public string Entrance { get; set; }

        /// <summary>
        /// 保额新值
        /// </summary>
        [JsonPropertyName("new_sum_insured")]
        public string NewSumInsured { get; set; }

        /// <summary>
        /// 领取时间
        /// </summary>
        [JsonPropertyName("offer_time")]
        public string OfferTime { get; set; }

        /// <summary>
        /// 保额旧值
        /// </summary>
        [JsonPropertyName("old_sum_insured")]
        public string OldSumInsured { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 赠险产品组类型。 赠险通用产品组 COMMON_GIFT_INSURANCE_PRODUCT_GROUP、 C端赠险产品组 CUSTOMER_GIFT_INSURANCE_PRODUCT_GROUP、 B端赠险产品组 BUSINESS_GIFT_INSURANCE_PRODUCT_GROUP、 相互保赠险产品组 XHB_GIFT_INSURANCE_PRODUCT_GROUP
        /// </summary>
        [JsonPropertyName("product_group_biz_type")]
        public string ProductGroupBizType { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 标准产品编号。7169 守护金，6325 多收多宝门诊，6349 免费医疗金
        /// </summary>
        [JsonPropertyName("sp_no")]
        public string SpNo { get; set; }

        /// <summary>
        /// 支付宝用户UID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
