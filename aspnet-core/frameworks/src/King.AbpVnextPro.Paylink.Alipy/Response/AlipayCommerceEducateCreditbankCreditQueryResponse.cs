using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateCreditbankCreditQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCreditbankCreditQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 学分信息
        /// </summary>
        [JsonPropertyName("credit")]
        public List<CreditBankCredit> Credit { get; set; }
    }
}
