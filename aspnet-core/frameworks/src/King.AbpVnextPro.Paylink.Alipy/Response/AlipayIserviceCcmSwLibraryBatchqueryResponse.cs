using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwLibraryBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceCcmSwLibraryBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 知识库集合
        /// </summary>
        [JsonPropertyName("libraries")]
        public List<LibraryInfo> Libraries { get; set; }
    }
}
