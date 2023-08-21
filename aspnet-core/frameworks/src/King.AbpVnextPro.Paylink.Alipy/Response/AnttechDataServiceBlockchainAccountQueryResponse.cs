using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AnttechDataServiceBlockchainAccountQueryResponse.
    /// </summary>
    public class AnttechDataServiceBlockchainAccountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 账户列表
        /// </summary>
        [JsonPropertyName("account_list")]
        public List<BlockChainAccountApiDO> AccountList { get; set; }
    }
}
