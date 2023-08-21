using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntfortuneContentCommunityLabelQueryModel Data Structure.
    /// </summary>
    public class AntfortuneContentCommunityLabelQueryModel : AlipayObject
    {
        /// <summary>
        /// 标签场景
        /// </summary>
        [JsonPropertyName("label_scene")]
        public string LabelScene { get; set; }
    }
}
