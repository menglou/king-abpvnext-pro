﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayBusinessOrderConsultModel Data Structure.
    /// </summary>
    public class AlipayBusinessOrderConsultModel : AlipayObject
    {
        /// <summary>
        /// 买家识别信息。  本接口场景下若无用户id信息，可扫用户付款页中条形码，传入条码信息（type为BAR_CODE，issuer为ALIPAY，identity为获取的用户条形码码值）
        /// </summary>
        [JsonPropertyName("buyer_identity")]
        public UserIdentity BuyerIdentity { get; set; }

        /// <summary>
        /// 经营环境信息
        /// </summary>
        [JsonPropertyName("env_info")]
        public EnvInfo EnvInfo { get; set; }

        /// <summary>
        /// 商品详情列表
        /// </summary>
        [JsonPropertyName("item_list")]
        public List<ItemDetail> ItemList { get; set; }
    }
}
