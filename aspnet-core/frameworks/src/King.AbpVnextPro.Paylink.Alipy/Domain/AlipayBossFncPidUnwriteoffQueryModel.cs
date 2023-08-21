﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayBossFncPidUnwriteoffQueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncPidUnwriteoffQueryModel : AlipayObject
    {
        /// <summary>
        /// 请求查询业务场景 INTER_TRADE:关联方场景 PROMOORDER:超级优惠购 IOT:iot IPAY_TAKEOUT_REDPACKET:国际外卖红包 ADCENTER:广告平台 AFC:金融云业务场景
        /// </summary>
        [JsonPropertyName("business_scene")]
        public string BusinessScene { get; set; }

        /// <summary>
        /// 结算对象PID
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }
    }
}
