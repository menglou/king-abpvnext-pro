﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// InsHealthSendFlowResult Data Structure.
    /// </summary>
    public class InsHealthSendFlowResult : AlipayObject
    {
        /// <summary>
        /// 业务类型。HEALTH_BEAN_SIMPLE_UPGRADE 免费医疗金、HEALTH_DSDB_NEW_OUTPATIENT 多收多宝新门诊、HEALTH_GUARDIAN_GOLD 守护金
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 入口
        /// </summary>
        [JsonPropertyName("entrance")]
        public string Entrance { get; set; }

        /// <summary>
        /// 发放时间
        /// </summary>
        [JsonPropertyName("offer_time")]
        public string OfferTime { get; set; }

        /// <summary>
        /// 发放流水的外部业务单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// COMMON_GIFT_INSURANCE_PRODUCT_GROUP 赠险通用产品组、CUSTOMER_GIFT_INSURANCE_PRODUCT_GROUP C端赠险产品组、BUSINESS_GIFT_INSURANCE_PRODUCT_GROUP B端赠险产品组、XHB_GIFT_INSURANCE_PRODUCT_GROUP 相互保赠险产品组
        /// </summary>
        [JsonPropertyName("product_group_biz_type")]
        public string ProductGroupBizType { get; set; }

        /// <summary>
        /// 发放保额
        /// </summary>
        [JsonPropertyName("product_sum_insured")]
        public string ProductSumInsured { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 发放状态。0代表发放未领取，1代表发放已领取
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户支付宝UID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
