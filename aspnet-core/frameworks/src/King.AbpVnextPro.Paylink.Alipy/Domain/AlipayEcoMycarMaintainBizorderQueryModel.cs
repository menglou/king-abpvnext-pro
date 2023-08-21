﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoMycarMaintainBizorderQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarMaintainBizorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 车主平台生成的订单号。
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
