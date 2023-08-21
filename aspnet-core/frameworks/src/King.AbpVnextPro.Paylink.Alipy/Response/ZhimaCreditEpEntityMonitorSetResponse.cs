using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaCreditEpEntityMonitorSetResponse.
    /// </summary>
    public class ZhimaCreditEpEntityMonitorSetResponse : AlipayResponse
    {
        /// <summary>
        /// 添加成功返回true, 失败返回false
        /// </summary>
        [JsonPropertyName("biz_success")]
        public bool BizSuccess { get; set; }
    }
}
