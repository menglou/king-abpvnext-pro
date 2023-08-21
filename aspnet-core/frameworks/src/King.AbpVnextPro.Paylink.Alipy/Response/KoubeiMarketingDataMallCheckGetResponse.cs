using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingDataMallCheckGetResponse.
    /// </summary>
    public class KoubeiMarketingDataMallCheckGetResponse : AlipayResponse
    {
        /// <summary>
        /// 返回数据字段
        /// </summary>
        [JsonPropertyName("data_results")]
        public List<DataSecCheckResult> DataResults { get; set; }
    }
}
