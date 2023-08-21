using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeDevicemodelAddResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeDevicemodelAddResponse : AlipayResponse
    {
        /// <summary>
        /// 设备机型id
        /// </summary>
        [JsonPropertyName("device_model_id")]
        public long DeviceModelId { get; set; }
    }
}
