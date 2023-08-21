using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiItemExtitemInfoDeleteResponse.
    /// </summary>
    public class KoubeiItemExtitemInfoDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 删除成功，返回主键id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
