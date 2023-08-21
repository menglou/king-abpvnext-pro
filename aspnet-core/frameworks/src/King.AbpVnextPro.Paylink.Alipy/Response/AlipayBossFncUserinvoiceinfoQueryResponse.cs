using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossFncUserinvoiceinfoQueryResponse.
    /// </summary>
    public class AlipayBossFncUserinvoiceinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询返回结果：开票资料
        /// </summary>
        [JsonPropertyName("result_set")]
        public UserInvoiceInfoOpenApiResponse ResultSet { get; set; }
    }
}
