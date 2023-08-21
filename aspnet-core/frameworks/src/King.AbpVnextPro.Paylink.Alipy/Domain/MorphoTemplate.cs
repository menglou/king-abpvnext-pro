using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MorphoTemplate Data Structure.
    /// </summary>
    public class MorphoTemplate : AlipayObject
    {
        /// <summary>
        /// 闪蝶搭建平台模板名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
