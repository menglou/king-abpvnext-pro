using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ItemCategoryVO Data Structure.
    /// </summary>
    public class ItemCategoryVO : AlipayObject
    {
        /// <summary>
        /// 商品类目ID及信息可通过 商品类目表 获取
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }
    }
}
