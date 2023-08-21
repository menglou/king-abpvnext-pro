using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeUselogBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeUselogBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 余额使用记录
        /// </summary>
        [JsonPropertyName("use_log_list")]
        public List<PayForPrivilegeRechargeCardUseLog> UseLogList { get; set; }
    }
}
