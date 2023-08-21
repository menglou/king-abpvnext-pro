using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateCreditbankTrainingQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCreditbankTrainingQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 培训记录
        /// </summary>
        [JsonPropertyName("training")]
        public List<CreditBankTraining> Training { get; set; }
    }
}
