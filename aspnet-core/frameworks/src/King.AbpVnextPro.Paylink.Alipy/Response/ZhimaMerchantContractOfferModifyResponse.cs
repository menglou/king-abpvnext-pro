using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaMerchantContractOfferModifyResponse.
    /// </summary>
    public class ZhimaMerchantContractOfferModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 业务操作结果，成功或失败
        /// </summary>
        [JsonPropertyName("biz_result")]
        public string BizResult { get; set; }
    }
}
