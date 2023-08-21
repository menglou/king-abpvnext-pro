using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppInspectSessionQueryResponse.
    /// </summary>
    public class AlipayEbppInspectSessionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 登录ID
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
