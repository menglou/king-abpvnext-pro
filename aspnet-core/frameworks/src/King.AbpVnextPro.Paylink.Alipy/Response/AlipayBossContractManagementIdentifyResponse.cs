using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossContractManagementIdentifyResponse.
    /// </summary>
    public class AlipayBossContractManagementIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 识别结果
        /// </summary>
        [JsonPropertyName("result_set")]
        public InterTradeConsultOpenApiResult ResultSet { get; set; }
    }
}
