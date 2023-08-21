using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// FengdieActivityCreateModel Data Structure.
    /// </summary>
    public class FengdieActivityCreateModel : AlipayObject
    {
        /// <summary>
        /// 云凤蝶站点的 id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public long ActivityId { get; set; }
    }
}
