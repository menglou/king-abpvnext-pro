using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AiOcrTableRow Data Structure.
    /// </summary>
    public class AiOcrTableRow : AlipayObject
    {
        /// <summary>
        /// table一行的内容
        /// </summary>
        [JsonPropertyName("row")]
        public List<AiOcrTableContext> Row { get; set; }
    }
}
