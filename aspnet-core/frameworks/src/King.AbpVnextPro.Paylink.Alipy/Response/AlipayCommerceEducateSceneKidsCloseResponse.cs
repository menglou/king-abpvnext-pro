using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateSceneKidsCloseResponse.
    /// </summary>
    public class AlipayCommerceEducateSceneKidsCloseResponse : AlipayResponse
    {
        /// <summary>
        /// 关闭业务是否成功
        /// </summary>
        [JsonPropertyName("close_success")]
        public string CloseSuccess { get; set; }
    }
}
