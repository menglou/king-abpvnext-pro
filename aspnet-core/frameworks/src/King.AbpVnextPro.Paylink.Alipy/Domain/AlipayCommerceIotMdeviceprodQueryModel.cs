using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备id（物料系统的id）
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }
    }
}
