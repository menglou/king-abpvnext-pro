﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampWhitelistCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampWhitelistCreateModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 用户信息列表，有多个时用逗号隔开，最大支持100个白名单账户，账户必须是非脱敏的登录账号或者2088开头的userid，以覆盖的形式执行。为空（“”）时，则清空白名单，不进行白名单校验。
        /// </summary>
        [JsonPropertyName("user_id_list")]
        public string UserIdList { get; set; }
    }
}
