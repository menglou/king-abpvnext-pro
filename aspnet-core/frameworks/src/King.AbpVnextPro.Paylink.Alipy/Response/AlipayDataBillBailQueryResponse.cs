using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataBillBailQueryResponse.
    /// </summary>
    public class AlipayDataBillBailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 保证金明细列表，最多返回5000条
        /// </summary>
        [JsonPropertyName("detail_list")]
        public List<BailDetailResult> DetailList { get; set; }
    }
}
