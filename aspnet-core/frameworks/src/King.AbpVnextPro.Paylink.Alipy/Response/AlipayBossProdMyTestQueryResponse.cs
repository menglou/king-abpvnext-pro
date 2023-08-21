using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossProdMyTestQueryResponse.
    /// </summary>
    public class AlipayBossProdMyTestQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }
    }
}
