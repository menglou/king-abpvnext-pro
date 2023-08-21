using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvDeviceBindResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvDeviceBindResponse : AlipayResponse
    {
        /// <summary>
        /// 设备注册是否成功
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
