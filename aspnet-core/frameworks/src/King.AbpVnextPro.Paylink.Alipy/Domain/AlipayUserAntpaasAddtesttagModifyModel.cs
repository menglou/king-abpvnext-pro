using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserAntpaasAddtesttagModifyModel Data Structure.
    /// </summary>
    public class AlipayUserAntpaasAddtesttagModifyModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账户id
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }
    }
}
