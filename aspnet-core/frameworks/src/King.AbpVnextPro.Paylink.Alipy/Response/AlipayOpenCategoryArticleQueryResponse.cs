using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenCategoryArticleQueryResponse.
    /// </summary>
    public class AlipayOpenCategoryArticleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 文章列表
        /// </summary>
        [JsonPropertyName("articles")]
        public List<LifeRecommendArticles> Articles { get; set; }
    }
}
