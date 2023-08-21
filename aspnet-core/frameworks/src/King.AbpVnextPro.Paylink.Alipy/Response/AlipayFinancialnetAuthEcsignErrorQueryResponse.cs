using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignErrorQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthEcsignErrorQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("error_log_list")]
        public List<ErrorLog> ErrorLogList { get; set; }
    }
}
