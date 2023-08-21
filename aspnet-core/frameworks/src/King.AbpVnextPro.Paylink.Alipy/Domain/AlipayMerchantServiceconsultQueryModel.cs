using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMerchantServiceconsultQueryModel Data Structure.
    /// </summary>
    public class AlipayMerchantServiceconsultQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝侧服务咨询工单号
        /// </summary>
        [JsonPropertyName("consult_event_id")]
        public string ConsultEventId { get; set; }
    }
}
