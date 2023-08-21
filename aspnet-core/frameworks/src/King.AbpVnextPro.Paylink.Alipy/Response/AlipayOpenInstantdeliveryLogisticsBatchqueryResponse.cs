using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryLogisticsBatchqueryResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryLogisticsBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支持的即时配送公司列表
        /// </summary>
        [JsonPropertyName("logistics_companys")]
        public List<LogisticsCompanyDTO> LogisticsCompanys { get; set; }
    }
}
