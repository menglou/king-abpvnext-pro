using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentItemQueryResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentItemQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [JsonPropertyName("items")]
        public List<AppContentItem> Items { get; set; }

        /// <summary>
        /// 总商品数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
