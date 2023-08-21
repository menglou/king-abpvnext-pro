using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayIserviceCcmFunctionQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmFunctionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 功能点列表
        /// </summary>
        [JsonPropertyName("functions")]
        public List<Function> Functions { get; set; }
    }
}
