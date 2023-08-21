using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoMycarDataserviceViolationinfoShareModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarDataserviceViolationinfoShareModel : AlipayObject
    {
        /// <summary>
        /// 支付宝app_id
        /// </summary>
        [JsonPropertyName("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        [JsonPropertyName("vehicle_id")]
        public string VehicleId { get; set; }
    }
}
