using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserCertifyIdentifyFileQueryModel Data Structure.
    /// </summary>
    public class AlipayUserCertifyIdentifyFileQueryModel : AlipayObject
    {
        /// <summary>
        /// 文件的地址
        /// </summary>
        [JsonPropertyName("file_url")]
        public string FileUrl { get; set; }
    }
}
