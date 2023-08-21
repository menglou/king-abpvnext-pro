using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossFncApinvoiceBatchAddResponse.
    /// </summary>
    public class AlipayBossFncApinvoiceBatchAddResponse : AlipayResponse
    {
        /// <summary>
        /// 批量发票关联账单，返回发票id及对应的账单+分配金额
        /// </summary>
        [JsonPropertyName("result_set")]
        public List<ApInvoiceBillAmtOpenApiResponse> ResultSet { get; set; }
    }
}
