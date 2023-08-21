using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaCustomerContractAcceptCreateResponse.
    /// </summary>
    public class ZhimaCustomerContractAcceptCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }
    }
}
