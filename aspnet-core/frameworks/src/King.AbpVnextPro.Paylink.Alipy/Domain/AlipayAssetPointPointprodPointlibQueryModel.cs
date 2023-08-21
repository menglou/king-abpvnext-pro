using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayAssetPointPointprodPointlibQueryModel Data Structure.
    /// </summary>
    public class AlipayAssetPointPointprodPointlibQueryModel : AlipayObject
    {
        /// <summary>
        /// 集分宝积分库ID
        /// </summary>
        [JsonPropertyName("point_lib_id")]
        public string PointLibId { get; set; }
    }
}
