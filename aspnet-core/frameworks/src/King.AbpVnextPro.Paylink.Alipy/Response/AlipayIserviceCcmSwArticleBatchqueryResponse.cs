using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwArticleBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceCcmSwArticleBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 文章信息
        /// </summary>
        [JsonPropertyName("articles")]
        public List<ArticleInfo> Articles { get; set; }
    }
}
