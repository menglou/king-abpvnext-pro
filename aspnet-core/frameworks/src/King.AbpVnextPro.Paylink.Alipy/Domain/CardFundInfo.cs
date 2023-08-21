using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// CardFundInfo Data Structure.
    /// </summary>
    public class CardFundInfo : AlipayObject
    {
        /// <summary>
        /// 消费资金账户
        /// </summary>
        [JsonPropertyName("fundaccount")]
        public string Fundaccount { get; set; }

        /// <summary>
        /// 消费资金类型
        /// </summary>
        [JsonPropertyName("fundtype")]
        public string Fundtype { get; set; }
    }
}
