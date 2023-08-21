using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceRecordsSetResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceRecordsSetResponse : AlipayResponse
    {
        /// <summary>
        /// 设备档案
        /// </summary>
        [JsonPropertyName("device_records")]
        public DeviceRecords DeviceRecords { get; set; }
    }
}
