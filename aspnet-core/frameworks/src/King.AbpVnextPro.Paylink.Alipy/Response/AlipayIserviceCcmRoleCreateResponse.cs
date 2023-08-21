using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayIserviceCcmRoleCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmRoleCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 角色id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
