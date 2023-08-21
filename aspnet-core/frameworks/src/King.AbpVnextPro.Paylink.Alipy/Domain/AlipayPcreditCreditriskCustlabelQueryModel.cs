using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayPcreditCreditriskCustlabelQueryModel Data Structure.
    /// </summary>
    public class AlipayPcreditCreditriskCustlabelQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝2088id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
