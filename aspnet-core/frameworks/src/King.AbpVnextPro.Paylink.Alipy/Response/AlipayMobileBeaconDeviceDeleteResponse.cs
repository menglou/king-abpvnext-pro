using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMobileBeaconDeviceDeleteResponse.
    /// </summary>
    public class AlipayMobileBeaconDeviceDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 操作返回码
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
