using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicGroupCreateResponse.
    /// </summary>
    public class AlipayOpenPublicGroupCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 分组id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }
    }
}
