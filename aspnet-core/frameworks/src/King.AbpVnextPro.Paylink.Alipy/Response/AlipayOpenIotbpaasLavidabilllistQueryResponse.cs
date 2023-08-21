using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenIotbpaasLavidabilllistQueryResponse.
    /// </summary>
    public class AlipayOpenIotbpaasLavidabilllistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 账单数量
        /// </summary>
        [JsonPropertyName("bill_count")]
        public long BillCount { get; set; }

        /// <summary>
        /// 账单列表
        /// </summary>
        [JsonPropertyName("bill_list")]
        public List<BillInfo> BillList { get; set; }
    }
}
