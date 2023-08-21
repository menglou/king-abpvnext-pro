﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMerchantActivityCreateModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignMerchantActivityCreateModel : AlipayObject
    {
        /// <summary>
        /// 活动是否需要自动续期
        /// </summary>
        [JsonPropertyName("auto_delay_flag")]
        public bool AutoDelayFlag { get; set; }

        /// <summary>
        /// 活动所属场景，只支持单个场景，目前支持枚举类型：点餐场景：DISH、预点餐场景：PRE_DISH、菜单场景：MENU
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 营销活动描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 活动结束时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展信息数据，如需要透传信息到口碑，需要结果带回，则传递该值
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<MExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 营销活动名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 指定operator字段操作人类型，目前支持枚举：外部商户：MER、商户操作员：MER_OPERATOR、外部服务商：PROVIDER、外部服务商员工：PROVIDER_STAFF
        /// </summary>
        [JsonPropertyName("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 活动外部业务类型，通过改类型指定营销活动是什么类型的活动，目前支持类型枚举值：会员券：MEMBER_CASH、会员折扣：MEMBER_RATE_DISCOUNT、会员价：MEMBER_DISH_ITEM
        /// </summary>
        [JsonPropertyName("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 外部请求号，控制幂等
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 营销活动玩法详细信息设置
        /// </summary>
        [JsonPropertyName("promo_info_list")]
        public List<MPromoInfo> PromoInfoList { get; set; }

        /// <summary>
        /// 活动开始时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
