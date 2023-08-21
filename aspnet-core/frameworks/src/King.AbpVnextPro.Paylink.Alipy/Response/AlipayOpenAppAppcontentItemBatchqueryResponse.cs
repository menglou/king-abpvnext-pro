using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentItemBatchqueryResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentItemBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [JsonPropertyName("items")]
        public List<AppContentItem> Items { get; set; }
    }
}
