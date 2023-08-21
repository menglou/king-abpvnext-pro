using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoMycarDataserviceMaintainvehicleShareResponse.
    /// </summary>
    public class AlipayEcoMycarDataserviceMaintainvehicleShareResponse : AlipayResponse
    {
        /// <summary>
        /// 车辆详细信息
        /// </summary>
        [JsonPropertyName("info")]
        public MaintainVehicleInfo Info { get; set; }
    }
}
