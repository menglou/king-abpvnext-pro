using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySecurityProdSignatureFileUploadResponse.
    /// </summary>
    public class AlipaySecurityProdSignatureFileUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 文件唯一标识，用于apply接口传入
        /// </summary>
        [JsonPropertyName("oss_file_id")]
        public string OssFileId { get; set; }
    }
}
