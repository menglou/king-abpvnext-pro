using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringPosOrderUploadResponse.
    /// </summary>
    public class KoubeiCateringPosOrderUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 生成序列号标记每次上传
        /// </summary>
        [JsonPropertyName("flow_id")]
        public string FlowId { get; set; }
    }
}
