﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanOfflineModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportAdPlanOfflineModel : AlipayObject
    {
        /// <summary>
        /// 广告主id + 下线计划操作时，需要校验该plan是否属于该广告主
        /// </summary>
        [JsonPropertyName("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 广告计划id + 根据广告计划id下线对应的广告计划
        /// </summary>
        [JsonPropertyName("plan_id")]
        public long PlanId { get; set; }
    }
}
