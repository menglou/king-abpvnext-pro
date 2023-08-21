﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiShopMallCardQueryResponse.
    /// </summary>
    public class KoubeiShopMallCardQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商圈发行的会员卡信息
        /// </summary>
        [JsonPropertyName("cards")]
        public List<MallCardBo> Cards { get; set; }

        /// <summary>
        /// 是否开通会员系统功能
        /// </summary>
        [JsonPropertyName("open")]
        public bool Open { get; set; }

        /// <summary>
        /// 商圈会员开卡链接
        /// </summary>
        [JsonPropertyName("open_card_url")]
        public string OpenCardUrl { get; set; }
    }
}
