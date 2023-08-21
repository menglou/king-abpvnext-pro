using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringPosCategoryQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosCategoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonPropertyName("cate_id")]
        public string CateId { get; set; }
    }
}
