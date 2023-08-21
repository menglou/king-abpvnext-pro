﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsAutoUserPointReceiveModel Data Structure.
    /// </summary>
    public class AlipayInsAutoUserPointReceiveModel : AlipayObject
    {
        /// <summary>
        /// 车险活动类型编码。  攒油：SAVE_OIL
        /// </summary>
        [JsonPropertyName("auto_campaign_type")]
        public string AutoCampaignType { get; set; }

        /// <summary>
        /// 扩展参数。  BIZ_END_TIME:业务结束时间，值为时间戳
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 车险活动的接入场景。  例如，车险攒油活动的接入场景码。  高德导航：gaode_use
        /// </summary>
        [JsonPropertyName("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
