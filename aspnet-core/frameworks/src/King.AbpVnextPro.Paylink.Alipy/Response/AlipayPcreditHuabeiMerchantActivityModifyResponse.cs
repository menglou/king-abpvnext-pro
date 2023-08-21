using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantActivityModifyResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantActivityModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 商户活动ID
        /// </summary>
        [JsonPropertyName("aggr_id")]
        public string AggrId { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
