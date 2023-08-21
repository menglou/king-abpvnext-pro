using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaCustomerContractDetailQueryResponse.
    /// </summary>
    public class ZhimaCustomerContractDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 合约详情
        /// </summary>
        [JsonPropertyName("contract_detail")]
        public ApiContractDetail ContractDetail { get; set; }
    }
}
