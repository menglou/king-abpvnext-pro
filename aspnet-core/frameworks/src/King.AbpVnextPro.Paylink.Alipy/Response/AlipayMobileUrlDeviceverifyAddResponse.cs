using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMobileUrlDeviceverifyAddResponse.
    /// </summary>
    public class AlipayMobileUrlDeviceverifyAddResponse : AlipayResponse
    {
        /// <summary>
        /// 返回业务操作是否成功
        /// </summary>
        [JsonPropertyName("response")]
        public bool Response { get; set; }
    }
}
