﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOverseasTransferBalanceQueryResponse.
    /// </summary>
    public class AlipayOverseasTransferBalanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 账户余额列表
        /// </summary>
        [JsonPropertyName("balances")]
        public List<Money> Balances { get; set; }

        /// <summary>
        /// 透传信息
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
