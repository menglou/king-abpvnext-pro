using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppJfexportChargeinstQueryResponse.
    /// </summary>
    public class AlipayEbppJfexportChargeinstQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 输出的机构列表
        /// </summary>
        [JsonPropertyName("charge_insts")]
        public List<JfExportChargeInstModel> ChargeInsts { get; set; }

        /// <summary>
        /// 开通的出账机构总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
