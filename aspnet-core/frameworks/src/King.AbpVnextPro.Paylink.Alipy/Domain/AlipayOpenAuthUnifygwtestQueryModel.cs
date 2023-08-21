using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAuthUnifygwtestQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthUnifygwtestQueryModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("str")]
        public string Str { get; set; }
    }
}
