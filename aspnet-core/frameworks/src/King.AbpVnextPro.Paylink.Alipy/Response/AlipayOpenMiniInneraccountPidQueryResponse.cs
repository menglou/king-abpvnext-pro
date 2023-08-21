using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniInneraccountPidQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInneraccountPidQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 虚拟PID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
