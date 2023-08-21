using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringPosMaterialCreateResponse.
    /// </summary>
    public class KoubeiCateringPosMaterialCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
