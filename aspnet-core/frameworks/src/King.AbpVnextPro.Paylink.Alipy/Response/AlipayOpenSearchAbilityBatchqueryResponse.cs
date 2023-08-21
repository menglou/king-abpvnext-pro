using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenSearchAbilityBatchqueryResponse.
    /// </summary>
    public class AlipayOpenSearchAbilityBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 搜索运营分页数据
        /// </summary>
        [JsonPropertyName("data")]
        public AbilityPageQueryDTO Data { get; set; }
    }
}
