using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// FengdieSuccessRespModel Data Structure.
    /// </summary>
    public class FengdieSuccessRespModel : AlipayObject
    {
        /// <summary>
        /// 判断请求操作是否成功，值为 true 或者 false
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
