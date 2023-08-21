﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserNewbenefitCreateModel Data Structure.
    /// </summary>
    public class AlipayUserNewbenefitCreateModel : AlipayObject
    {
        /// <summary>
        /// 关联的专区码，需要联系蚂蚁会员平台的业务负责人进行专区码分配
        /// </summary>
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 权益的名称，由调用方自行定义
        /// </summary>
        [JsonPropertyName("benefit_name")]
        public string BenefitName { get; set; }

        /// <summary>
        /// 权益的副标题，用于补充描述权益
        /// </summary>
        [JsonPropertyName("benefit_sub_title")]
        public string BenefitSubTitle { get; set; }

        /// <summary>
        /// 权益详情描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Y表示差异化，N表示非差异化；差异化的权益需要为四个等级分别配置等级配置，包括积分、折扣、跳转页面等信息；非差异化的权益只需要配置一个通用的等级配置
        /// </summary>
        [JsonPropertyName("differentiation")]
        public string Differentiation { get; set; }

        /// <summary>
        /// 当权益为非差异化时，该字段生效，用于控制允许兑换权益的等级
        /// </summary>
        [JsonPropertyName("eligible_grade_desc")]
        public string EligibleGradeDesc { get; set; }

        /// <summary>
        /// 权益展示结束时间，使用Date.getTime()。结束时间必须大于起始时间。
        /// </summary>
        [JsonPropertyName("end_dt")]
        public long EndDt { get; set; }

        /// <summary>
        /// 兑换规则以及不满足该规则后给用户的提示文案，规则id和文案用:分隔；可配置多个，多个之间用,分隔。(分隔符皆是英文半角字符)规则id联系蚂蚁会员pd或运营提供
        /// </summary>
        [JsonPropertyName("exchange_rule_ids")]
        public string ExchangeRuleIds { get; set; }

        /// <summary>
        /// 权益等级配置
        /// </summary>
        [JsonPropertyName("grade_config")]
        public List<BenefitGradeConfig> GradeConfig { get; set; }

        /// <summary>
        /// 权益展示时的图标地址，由商户上传图片到合适的存储平台，然后将图片的地址传入
        /// </summary>
        [JsonPropertyName("icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// 权益展示的起始时间戳，使用Date.getTime()获得
        /// </summary>
        [JsonPropertyName("start_dt")]
        public long StartDt { get; set; }
    }
}
