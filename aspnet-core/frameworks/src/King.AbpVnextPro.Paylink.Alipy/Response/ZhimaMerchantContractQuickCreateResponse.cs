using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaMerchantContractQuickCreateResponse.
    /// </summary>
    public class ZhimaMerchantContractQuickCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 错误说明
        /// </summary>
        [JsonPropertyName("biz_desc")]
        public string BizDesc { get; set; }

        /// <summary>
        /// 发约单单号
        /// </summary>
        [JsonPropertyName("offer_no")]
        public string OfferNo { get; set; }
    }
}
