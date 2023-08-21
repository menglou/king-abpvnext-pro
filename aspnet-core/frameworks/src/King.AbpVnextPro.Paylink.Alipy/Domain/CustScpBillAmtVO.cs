﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// CustScpBillAmtVO Data Structure.
    /// </summary>
    public class CustScpBillAmtVO : AlipayObject
    {
        /// <summary>
        /// 费用
        /// </summary>
        [JsonPropertyName("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 本金
        /// </summary>
        [JsonPropertyName("prin")]
        public string Prin { get; set; }
    }
}
