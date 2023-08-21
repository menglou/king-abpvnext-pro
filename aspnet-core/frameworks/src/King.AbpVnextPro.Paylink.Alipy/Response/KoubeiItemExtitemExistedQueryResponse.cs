﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiItemExtitemExistedQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemExistedQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品库中存在的商品编码
        /// </summary>
        [JsonPropertyName("existed_list")]
        public List<string> ExistedList { get; set; }
    }
}
