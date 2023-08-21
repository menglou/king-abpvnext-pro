using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringPosSpecSyncResponse.
    /// </summary>
    public class KoubeiCateringPosSpecSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 返回ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
