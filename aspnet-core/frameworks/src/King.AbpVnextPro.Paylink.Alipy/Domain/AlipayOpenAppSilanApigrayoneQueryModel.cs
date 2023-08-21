using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAppSilanApigrayoneQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppSilanApigrayoneQueryModel : AlipayObject
    {
        /// <summary>
        /// param
        /// </summary>
        [JsonPropertyName("param_1")]
        public string Param1 { get; set; }
    }
}
