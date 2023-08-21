using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAppDedfDdQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppDedfDdQueryModel : AlipayObject
    {
        /// <summary>
        /// 10
        /// </summary>
        [JsonPropertyName("zyde")]
        public string Zyde { get; set; }
    }
}
