using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeProductBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeProductBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户设备产品列表
        /// </summary>
        [JsonPropertyName("product_list")]
        public List<AmpeProductInfo> ProductList { get; set; }
    }
}
