using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceSchemaQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppServiceSchemaQueryModel : AlipayObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }
    }
}
