using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoMycarViolationVehicleQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarViolationVehicleQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户车辆ID,支付宝系统唯一
        /// </summary>
        [JsonPropertyName("vi_id")]
        public string ViId { get; set; }
    }
}
