using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserIdenticalAuthbaseQueryResponse.
    /// </summary>
    public class AlipayUserIdenticalAuthbaseQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否是同人账号
        /// </summary>
        [JsonPropertyName("identical")]
        public bool Identical { get; set; }
    }
}
