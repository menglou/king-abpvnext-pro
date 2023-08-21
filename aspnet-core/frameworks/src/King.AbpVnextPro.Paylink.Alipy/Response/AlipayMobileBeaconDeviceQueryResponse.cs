using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMobileBeaconDeviceQueryResponse.
    /// </summary>
    public class AlipayMobileBeaconDeviceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 蓝牙设备信息
        /// </summary>
        [JsonPropertyName("beacon_device_info")]
        public BeaconDeviceInfo BeaconDeviceInfo { get; set; }

        /// <summary>
        /// 操作返回码，200为成功
        /// </summary>
        [JsonPropertyName("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 请求处理结果
        /// </summary>
        [JsonPropertyName("msg")]
        public new string Msg { get; set; }
    }
}
