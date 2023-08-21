using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAuthAppCancelResponse.
    /// </summary>
    public class AlipayOpenAuthAppCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 取消授权结果
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
