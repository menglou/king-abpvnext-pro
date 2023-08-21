﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankCreditGuaranteeContractSignResponse.
    /// </summary>
    public class MybankCreditGuaranteeContractSignResponse : AlipayResponse
    {
        /// <summary>
        /// 合约号。调用成功则返回签约合约号
        /// </summary>
        [JsonPropertyName("ar_no")]
        public string ArNo { get; set; }
    }
}
