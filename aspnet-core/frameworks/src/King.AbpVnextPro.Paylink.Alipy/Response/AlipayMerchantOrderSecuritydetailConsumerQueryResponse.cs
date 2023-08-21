using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMerchantOrderSecuritydetailConsumerQueryResponse.
    /// </summary>
    public class AlipayMerchantOrderSecuritydetailConsumerQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单信息  若订单号或业务号存在，则返回
        /// </summary>
        [JsonPropertyName("order_info")]
        public AlipayOrderDataOpenapiResultInfo OrderInfo { get; set; }
    }
}
