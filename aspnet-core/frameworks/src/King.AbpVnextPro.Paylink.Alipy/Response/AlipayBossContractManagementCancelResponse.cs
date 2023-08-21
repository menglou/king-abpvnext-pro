using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossContractManagementCancelResponse.
    /// </summary>
    public class AlipayBossContractManagementCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 撤销操作提示
        /// </summary>
        [JsonPropertyName("result_set")]
        public string ResultSet { get; set; }
    }
}
