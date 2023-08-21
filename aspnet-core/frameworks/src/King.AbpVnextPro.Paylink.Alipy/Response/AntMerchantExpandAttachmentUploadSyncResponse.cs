using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandAttachmentUploadSyncResponse.
    /// </summary>
    public class AntMerchantExpandAttachmentUploadSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 响应结果
        /// </summary>
        [JsonPropertyName("upload_result")]
        public AssetResult UploadResult { get; set; }
    }
}
