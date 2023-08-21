﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiRetailShopitemBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiRetailShopitemBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 查询店铺商品查询入参
        /// </summary>
        [JsonPropertyName("shop_items")]
        public List<RequestExtShopItemQuery> ShopItems { get; set; }
    }
}
