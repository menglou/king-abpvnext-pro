using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceFixAttachmentUploadResponse.
    /// </summary>
    public class AlipayCommerceFixAttachmentUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 上传文件的内容。
        /// </summary>
        [JsonPropertyName("file_info")]
        public FixFileInfo FileInfo { get; set; }
    }
}
