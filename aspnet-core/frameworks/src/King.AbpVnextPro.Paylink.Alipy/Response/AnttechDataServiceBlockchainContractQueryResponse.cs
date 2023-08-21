using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AnttechDataServiceBlockchainContractQueryResponse.
    /// </summary>
    public class AnttechDataServiceBlockchainContractQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 合约列表
        /// </summary>
        [JsonPropertyName("contract_list")]
        public List<BlockChainContractApiDO> ContractList { get; set; }
    }
}
