﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerclientinfoDefaultversionQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniInnerclientinfoDefaultversionQueryModel : AlipayObject
    {
        /// <summary>
        /// 小程序Id
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
