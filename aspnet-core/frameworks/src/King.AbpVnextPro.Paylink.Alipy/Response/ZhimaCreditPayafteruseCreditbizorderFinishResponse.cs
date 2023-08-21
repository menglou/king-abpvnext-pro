using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditbizorderFinishResponse.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditbizorderFinishResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻后付订单号
        /// </summary>
        [JsonPropertyName("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 商户外部请求号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
