using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringPosStallCreateResponse.
    /// </summary>
    public class KoubeiCateringPosStallCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 档口id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
