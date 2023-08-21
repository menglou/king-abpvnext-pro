using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntfortuneContentCommunitySubtitleQueryResponse.
    /// </summary>
    public class AntfortuneContentCommunitySubtitleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 纠偏后的结果
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 字幕部分透传的字段
        /// </summary>
        [JsonPropertyName("ext")]
        public AliveSubtitleExt Ext { get; set; }

        /// <summary>
        /// 直播Id
        /// </summary>
        [JsonPropertyName("live_id")]
        public string LiveId { get; set; }
    }
}
