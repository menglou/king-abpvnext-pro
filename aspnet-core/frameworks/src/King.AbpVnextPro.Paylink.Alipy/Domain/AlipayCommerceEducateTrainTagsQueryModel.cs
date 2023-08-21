using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTrainTagsQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateTrainTagsQueryModel : AlipayObject
    {
        /// <summary>
        /// 场景类型
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }
    }
}
