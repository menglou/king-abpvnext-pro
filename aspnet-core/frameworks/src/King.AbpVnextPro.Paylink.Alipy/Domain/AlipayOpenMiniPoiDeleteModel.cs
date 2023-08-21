using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenMiniPoiDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniPoiDeleteModel : AlipayObject
    {
        /// <summary>
        /// poi id，地理位置标记信息
        /// </summary>
        [JsonPropertyName("poi_id")]
        public string PoiId { get; set; }
    }
}
