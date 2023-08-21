using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AnttechDataServiceBlockchainTransactionQueryResponse.
    /// </summary>
    public class AnttechDataServiceBlockchainTransactionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 交易列表
        /// </summary>
        [JsonPropertyName("transaction_list")]
        public List<BlockChainTransactionApiDO> TransactionList { get; set; }
    }
}
