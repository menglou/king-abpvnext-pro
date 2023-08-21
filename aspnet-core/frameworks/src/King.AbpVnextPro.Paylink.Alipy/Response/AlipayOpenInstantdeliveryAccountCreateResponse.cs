using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryAccountCreateResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryAccountCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 配送公司账户创建结果列表
        /// </summary>
        [JsonPropertyName("logistics_account_status")]
        public List<LogisticsAccountStatusDTO> LogisticsAccountStatus { get; set; }
    }
}
