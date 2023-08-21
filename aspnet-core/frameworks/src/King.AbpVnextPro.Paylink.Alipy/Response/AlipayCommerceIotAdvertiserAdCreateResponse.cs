using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdCreateResponse.
    /// </summary>
    public class AlipayCommerceIotAdvertiserAdCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 投放计划id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
