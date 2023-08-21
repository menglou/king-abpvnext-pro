using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandFrontcategorySecurityDeleteModel Data Structure.
    /// </summary>
    public class AntMerchantExpandFrontcategorySecurityDeleteModel : AlipayObject
    {
        /// <summary>
        /// 前台类目ID
        /// </summary>
        [JsonPropertyName("front_category_id")]
        public string FrontCategoryId { get; set; }
    }
}
