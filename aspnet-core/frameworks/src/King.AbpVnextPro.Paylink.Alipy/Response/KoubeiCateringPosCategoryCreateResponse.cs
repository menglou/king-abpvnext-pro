using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringPosCategoryCreateResponse.
    /// </summary>
    public class KoubeiCateringPosCategoryCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 新建菜类ID
        /// </summary>
        [JsonPropertyName("cate_id")]
        public string CateId { get; set; }
    }
}
