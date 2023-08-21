using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorFreezeResponse.
    /// </summary>
    public class KoubeiMerchantOperatorFreezeResponse : AlipayResponse
    {
        /// <summary>
        /// 操作结果 true:success, false: failed
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
