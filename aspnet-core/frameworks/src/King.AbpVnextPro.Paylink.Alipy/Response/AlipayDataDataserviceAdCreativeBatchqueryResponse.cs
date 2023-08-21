using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdCreativeBatchqueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdCreativeBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 创意按条件分页查询结果
        /// </summary>
        [JsonPropertyName("creative_list")]
        public PageCreative CreativeList { get; set; }
    }
}
