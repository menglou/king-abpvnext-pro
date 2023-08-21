using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeDevicemodelBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeDevicemodelBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 产品机型列表
        /// </summary>
        [JsonPropertyName("product_info")]
        public AmpeProductInfo ProductInfo { get; set; }
    }
}
