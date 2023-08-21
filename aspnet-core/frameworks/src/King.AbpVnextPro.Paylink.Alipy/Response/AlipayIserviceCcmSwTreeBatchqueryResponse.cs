using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwTreeBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceCcmSwTreeBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 类目集合
        /// </summary>
        [JsonPropertyName("trees")]
        public List<TreeInfo> Trees { get; set; }
    }
}
