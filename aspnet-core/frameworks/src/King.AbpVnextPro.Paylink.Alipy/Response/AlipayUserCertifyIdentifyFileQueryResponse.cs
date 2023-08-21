using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserCertifyIdentifyFileQueryResponse.
    /// </summary>
    public class AlipayUserCertifyIdentifyFileQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 文件的base64数据，一般情况是小于2M的
        /// </summary>
        [JsonPropertyName("file")]
        public string File { get; set; }
    }
}
