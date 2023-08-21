using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntOcrDriverlicenseIdentifyResponse.
    /// </summary>
    public class AntOcrDriverlicenseIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 识别结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
