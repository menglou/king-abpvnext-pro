using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoMycarVehicleInfoQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarVehicleInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        [JsonPropertyName("vi_id")]
        public string ViId { get; set; }
    }
}
