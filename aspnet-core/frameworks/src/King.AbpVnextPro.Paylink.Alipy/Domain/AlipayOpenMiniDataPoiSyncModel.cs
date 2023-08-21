using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenMiniDataPoiSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniDataPoiSyncModel : AlipayObject
    {
        /// <summary>
        /// poi回流数据
        /// </summary>
        [JsonPropertyName("poi_data")]
        public PoiSyncData PoiData { get; set; }
    }
}
