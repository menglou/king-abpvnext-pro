using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAccountAliyunUnbindResponse.
    /// </summary>
    public class AlipayOpenAccountAliyunUnbindResponse : AlipayResponse
    {
        /// <summary>
        /// 解绑结果，true解绑成功，false解绑失败
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
