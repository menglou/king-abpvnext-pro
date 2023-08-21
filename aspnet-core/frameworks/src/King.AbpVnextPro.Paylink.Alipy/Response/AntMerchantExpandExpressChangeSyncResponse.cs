using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandExpressChangeSyncResponse.
    /// </summary>
    public class AntMerchantExpandExpressChangeSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 响应参数
        /// </summary>
        [JsonPropertyName("upload_result")]
        public AssetResult UploadResult { get; set; }
    }
}
