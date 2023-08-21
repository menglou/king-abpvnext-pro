using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingParkinglotinfoCreateResponse.
    /// </summary>
    public class AlipayEcoMycarParkingParkinglotinfoCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝返回停车场id。成功不为空，失败返回空
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }
    }
}
