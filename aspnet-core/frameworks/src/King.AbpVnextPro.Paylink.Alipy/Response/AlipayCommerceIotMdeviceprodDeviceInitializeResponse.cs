using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodDeviceInitializeResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodDeviceInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }
    }
}
