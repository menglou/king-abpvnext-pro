﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiRetailWmsGoodssafetyinventoryModifyModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsGoodssafetyinventoryModifyModel : AlipayObject
    {
        /// <summary>
        /// 货品安全库存
        /// </summary>
        [JsonPropertyName("goods_safety_inventorys")]
        public List<GoodsSafetyInventory> GoodsSafetyInventorys { get; set; }
    }
}
