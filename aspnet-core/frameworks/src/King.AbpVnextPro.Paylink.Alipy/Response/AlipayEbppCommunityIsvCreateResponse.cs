using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppCommunityIsvCreateResponse.
    /// </summary>
    public class AlipayEbppCommunityIsvCreateResponse : AlipayResponse
    {
        /// <summary>
        /// ISV短名
        /// </summary>
        [JsonPropertyName("isv_short_name")]
        public string IsvShortName { get; set; }
    }
}
