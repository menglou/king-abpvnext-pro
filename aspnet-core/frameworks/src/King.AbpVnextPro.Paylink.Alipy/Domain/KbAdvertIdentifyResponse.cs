﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KbAdvertIdentifyResponse Data Structure.
    /// </summary>
    public class KbAdvertIdentifyResponse : AlipayObject
    {
        /// <summary>
        /// 根据benefit_type，确定ID含义  SINGLE_VOUCHER时，benefit_ids为券ID
        /// </summary>
        [JsonPropertyName("benefit_ids")]
        public List<string> BenefitIds { get; set; }

        /// <summary>
        /// 发放权益类型  SINGLE_VOUCHER：单券
        /// </summary>
        [JsonPropertyName("benefit_type")]
        public string BenefitType { get; set; }

        /// <summary>
        /// 返回码  success: 成功  invalid-arguments: 无效参数  retry-exception: 异常请重试  isv.user-already-get-voucher：用户已经领过该券，同时券状态为有效  isv.item_inventory_not_enough:优惠领光了  isv.item_not_in_this_shop_sales:不是该商家的优惠，不能领取  isv.voucher_activity_not_started:活动未开始  isv.voucher_activity_expired:活动已结束  isv.crowd_limit_not_match_error:暂无领取资格，详情请咨询商家  isv.member_crowd_limit_not_match_error:会员专属，请先注册会员
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// JSON格式数据，alipass_url为打开钱包的地址
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 主键的值
        /// </summary>
        [JsonPropertyName("identify")]
        public string Identify { get; set; }

        /// <summary>
        /// 主键类型
        /// </summary>
        [JsonPropertyName("identify_type")]
        public string IdentifyType { get; set; }
    }
}
