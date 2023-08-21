using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoMycarDataserviceMaintainvehicleShareModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarDataserviceMaintainvehicleShareModel : AlipayObject
    {
        /// <summary>
        /// 车辆ID
        /// </summary>
        [JsonPropertyName("vid")]
        public string Vid { get; set; }
    }
}
