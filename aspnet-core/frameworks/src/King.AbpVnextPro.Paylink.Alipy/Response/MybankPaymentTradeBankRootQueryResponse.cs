using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankPaymentTradeBankRootQueryResponse.
    /// </summary>
    public class MybankPaymentTradeBankRootQueryResponse : AlipayResponse
    {
        /// <summary>
        /// Institution列表
        /// </summary>
        [JsonPropertyName("bank_details")]
        public List<Institution> BankDetails { get; set; }
    }
}
