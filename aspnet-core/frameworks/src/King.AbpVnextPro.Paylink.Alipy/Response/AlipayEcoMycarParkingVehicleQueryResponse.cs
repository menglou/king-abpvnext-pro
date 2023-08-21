using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingVehicleQueryResponse.
    /// </summary>
    public class AlipayEcoMycarParkingVehicleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 车牌信息（utf-8编码）
        /// </summary>
        [JsonPropertyName("car_number")]
        public string CarNumber { get; set; }
    }
}
