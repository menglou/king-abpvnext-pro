using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayZdataassetsEasyserviceResponse.
    /// </summary>
    public class AlipayZdataassetsEasyserviceResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
