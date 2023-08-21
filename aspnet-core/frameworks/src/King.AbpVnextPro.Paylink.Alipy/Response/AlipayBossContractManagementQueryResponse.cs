using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossContractManagementQueryResponse.
    /// </summary>
    public class AlipayBossContractManagementQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询结果
        /// </summary>
        [JsonPropertyName("result_set")]
        public ContractBatchInfoOpenApiResult ResultSet { get; set; }
    }
}
