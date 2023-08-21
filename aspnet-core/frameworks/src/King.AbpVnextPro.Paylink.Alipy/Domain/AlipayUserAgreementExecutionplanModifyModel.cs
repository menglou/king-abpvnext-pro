﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserAgreementExecutionplanModifyModel Data Structure.
    /// </summary>
    public class AlipayUserAgreementExecutionplanModifyModel : AlipayObject
    {
        /// <summary>
        /// 周期性扣款产品，授权免密支付协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 商户下一次扣款时间
        /// </summary>
        [JsonPropertyName("deduct_time")]
        public string DeductTime { get; set; }

        /// <summary>
        /// 具体修改原因
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }
    }
}
