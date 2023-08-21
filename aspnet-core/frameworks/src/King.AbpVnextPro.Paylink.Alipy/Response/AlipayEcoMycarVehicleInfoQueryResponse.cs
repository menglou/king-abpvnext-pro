using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoMycarVehicleInfoQueryResponse.
    /// </summary>
    public class AlipayEcoMycarVehicleInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 车辆信息列表
        /// </summary>
        [JsonPropertyName("vehicle_list")]
        public List<VehicleInfoDto> VehicleList { get; set; }
    }
}
