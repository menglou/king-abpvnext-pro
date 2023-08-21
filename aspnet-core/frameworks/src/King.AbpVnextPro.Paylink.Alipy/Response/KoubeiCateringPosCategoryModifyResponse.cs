using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringPosCategoryModifyResponse.
    /// </summary>
    public class KoubeiCateringPosCategoryModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 类别ID
        /// </summary>
        [JsonPropertyName("cate_id")]
        public string CateId { get; set; }
    }
}
