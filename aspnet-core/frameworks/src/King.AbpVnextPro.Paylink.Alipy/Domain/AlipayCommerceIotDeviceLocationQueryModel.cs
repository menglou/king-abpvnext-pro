using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceLocationQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotDeviceLocationQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备唯一标识，设备id
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }
    }
}
