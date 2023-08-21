using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandIotdeviceRecycleModifyResponse.
    /// </summary>
    public class AntMerchantExpandIotdeviceRecycleModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 业务处理订单号
        /// </summary>
        [JsonPropertyName("biz_order_id")]
        public string BizOrderId { get; set; }
    }
}
