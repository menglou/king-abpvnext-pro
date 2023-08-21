using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationBatchqueryResponse.
    /// </summary>
    public class AlipayInsSceneApplicationBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 投保单列表
        /// </summary>
        [JsonPropertyName("applications")]
        public List<InsApplicationQuery> Applications { get; set; }
    }
}
