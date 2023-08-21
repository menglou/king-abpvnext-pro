using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegePromconfigureSetResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegePromconfigureSetResponse : AlipayResponse
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
