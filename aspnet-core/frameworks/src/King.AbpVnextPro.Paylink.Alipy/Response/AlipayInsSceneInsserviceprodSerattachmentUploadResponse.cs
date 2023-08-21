using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSerattachmentUploadResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodSerattachmentUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 附件编号(业务主键)
        /// </summary>
        [JsonPropertyName("attachment_no")]
        public string AttachmentNo { get; set; }
    }
}
