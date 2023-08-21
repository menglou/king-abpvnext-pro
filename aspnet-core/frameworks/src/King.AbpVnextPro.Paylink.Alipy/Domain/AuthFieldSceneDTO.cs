using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AuthFieldSceneDTO Data Structure.
    /// </summary>
    public class AuthFieldSceneDTO : AlipayObject
    {
        /// <summary>
        /// 场景CODE
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景code描述
        /// </summary>
        [JsonPropertyName("scene_desc")]
        public string SceneDesc { get; set; }
    }
}
