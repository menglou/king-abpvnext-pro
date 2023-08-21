using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringDishVirtualcategoryDeleteResponse.
    /// </summary>
    public class KoubeiCateringDishVirtualcategoryDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 是否重试，true：需要重试；false：不需要重试
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
