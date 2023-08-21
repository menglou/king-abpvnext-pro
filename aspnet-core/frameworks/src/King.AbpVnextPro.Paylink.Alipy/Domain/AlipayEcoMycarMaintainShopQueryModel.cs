﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoMycarMaintainShopQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarMaintainShopQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部门店编号（与shop_id二选一，不能都为空）
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 车主平台门店编号（与out_shop_id二选一，不能都为空）
        /// </summary>
        [JsonPropertyName("shop_id")]
        public long ShopId { get; set; }
    }
}
