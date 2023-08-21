using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// QueryInstBillDetail Data Structure.
    /// </summary>
    public class QueryInstBillDetail : AlipayObject
    {
        /// <summary>
        /// 明细key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 明细描述
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 明细对应值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
