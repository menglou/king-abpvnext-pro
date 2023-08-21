﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOverseasTaxOrderQueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasTaxOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 退税机构业务流水号，唯一，由退税机构生成，只能包含英字母、数字，长度不能小于3且不能大于64
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
