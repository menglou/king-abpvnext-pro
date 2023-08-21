using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaCustomerEpIdentificationInitializeResponse.
    /// </summary>
    public class ZhimaCustomerEpIdentificationInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 本次认证的唯一标识，商户需要记录，后续的操作都需要用到。
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }
    }
}
