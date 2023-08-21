using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayAccountFinriskInstriskmonitorKeywordsBatchqueryResponse.
    /// </summary>
    public class AlipayAccountFinriskInstriskmonitorKeywordsBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回机构关键词相关信息
        /// </summary>
        [JsonPropertyName("result")]
        public List<string> Result { get; set; }
    }
}
