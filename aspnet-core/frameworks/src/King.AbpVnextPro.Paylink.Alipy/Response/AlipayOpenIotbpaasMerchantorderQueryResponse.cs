using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenIotbpaasMerchantorderQueryResponse.
    /// </summary>
    public class AlipayOpenIotbpaasMerchantorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单列表
        /// </summary>
        [JsonPropertyName("order_list")]
        public List<IoTBPaaSMerchantOrderInfo> OrderList { get; set; }
    }
}
