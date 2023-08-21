using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// Building Data Structure.
    /// </summary>
    public class Building : AlipayObject
    {
        /// <summary>
        /// 建筑名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// POI类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
