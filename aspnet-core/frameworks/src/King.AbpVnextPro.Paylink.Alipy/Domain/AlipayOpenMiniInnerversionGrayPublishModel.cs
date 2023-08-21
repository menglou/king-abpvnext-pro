﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionGrayPublishModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerversionGrayPublishModel : AlipayObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [JsonPropertyName("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序版本
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 待邀测应用列表，灰度插件时使用，如无邀测必要请不要传入
        /// </summary>
        [JsonPropertyName("beta_app_id_list")]
        public List<string> BetaAppIdList { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 灰度值
        /// </summary>
        [JsonPropertyName("gray_strategy")]
        public string GrayStrategy { get; set; }

        /// <summary>
        /// 小程序ID，仅特殊场景使用，普通业务方无需关注该参数
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序所属PID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
