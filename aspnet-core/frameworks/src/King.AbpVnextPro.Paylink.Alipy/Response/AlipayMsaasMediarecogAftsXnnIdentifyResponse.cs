using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogAftsXnnIdentifyResponse.
    /// </summary>
    public class AlipayMsaasMediarecogAftsXnnIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 算法返回结果，json字符串
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
