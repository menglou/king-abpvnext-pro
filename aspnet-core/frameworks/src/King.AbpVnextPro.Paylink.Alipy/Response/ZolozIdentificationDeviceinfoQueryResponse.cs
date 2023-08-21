using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZolozIdentificationDeviceinfoQueryResponse.
    /// </summary>
    public class ZolozIdentificationDeviceinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// device_info
        /// </summary>
        [JsonPropertyName("device_info")]
        public ZolozDeviceInfo DeviceInfo { get; set; }
    }
}
