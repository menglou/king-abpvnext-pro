using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceIcrowdUseResponse.
    /// </summary>
    public class AlipayDataDataserviceIcrowdUseResponse : AlipayResponse
    {
        /// <summary>
        /// 接口返回内容
        /// </summary>
        [JsonPropertyName("icrowd_use_resp")]
        public IcrowdUseResp IcrowdUseResp { get; set; }
    }
}
