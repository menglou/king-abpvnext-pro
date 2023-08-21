using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMobileDeviceinfoDynamicinfoAddResponse.
    /// </summary>
    public class AlipayMobileDeviceinfoDynamicinfoAddResponse : AlipayResponse
    {
        /// <summary>
        /// 同步处理结果
        /// </summary>
        [JsonPropertyName("operateresult")]
        public bool Operateresult { get; set; }
    }
}
