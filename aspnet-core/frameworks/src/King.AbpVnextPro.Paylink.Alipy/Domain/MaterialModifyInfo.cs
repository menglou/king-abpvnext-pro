using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MaterialModifyInfo Data Structure.
    /// </summary>
    public class MaterialModifyInfo : AlipayObject
    {
        /// <summary>
        /// 素材内容（素材地址或素材KEY）
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 素材类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
