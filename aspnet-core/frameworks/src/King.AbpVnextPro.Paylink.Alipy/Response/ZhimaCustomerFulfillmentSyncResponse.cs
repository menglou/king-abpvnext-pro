using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaCustomerFulfillmentSyncResponse.
    /// </summary>
    public class ZhimaCustomerFulfillmentSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("contract_nos")]
        public List<string> ContractNos { get; set; }
    }
}
