using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AdMaterialInfo Data Structure.
    /// </summary>
    public class AdMaterialInfo : AlipayObject
    {
        /// <summary>
        /// 物料id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 物料地址
        /// </summary>
        [JsonPropertyName("material_url")]
        public string MaterialUrl { get; set; }
    }
}
