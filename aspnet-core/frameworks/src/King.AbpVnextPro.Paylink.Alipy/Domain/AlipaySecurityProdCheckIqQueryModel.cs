using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipaySecurityProdCheckIqQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdCheckIqQueryModel : AlipayObject
    {
        /// <summary>
        /// 纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }
    }
}
