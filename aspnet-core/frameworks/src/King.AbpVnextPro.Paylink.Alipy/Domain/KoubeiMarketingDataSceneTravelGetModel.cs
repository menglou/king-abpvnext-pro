﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMarketingDataSceneTravelGetModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataSceneTravelGetModel : AlipayObject
    {
        /// <summary>
        /// 出行营销场景业务参数
        /// </summary>
        [JsonPropertyName("biz_info")]
        public TravelScene BizInfo { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 场景类型，固定值：TRAVEL
        /// </summary>
        [JsonPropertyName("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
