using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicComptestCreateResponse.
    /// </summary>
    public class AlipayOpenPublicComptestCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [JsonPropertyName("resulttwo")]
        public string Resulttwo { get; set; }
    }
}
