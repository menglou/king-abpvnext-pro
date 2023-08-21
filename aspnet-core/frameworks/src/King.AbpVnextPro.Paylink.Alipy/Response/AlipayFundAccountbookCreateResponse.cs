using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayFundAccountbookCreateResponse.
    /// </summary>
    public class AlipayFundAccountbookCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 开通的资金记账本id
        /// </summary>
        [JsonPropertyName("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 网银入金的外标卡信息
        /// </summary>
        [JsonPropertyName("ext_card_info")]
        public ExtCardInfo ExtCardInfo { get; set; }
    }
}
