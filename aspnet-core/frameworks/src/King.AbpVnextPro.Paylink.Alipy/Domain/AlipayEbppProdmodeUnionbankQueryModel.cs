using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeUnionbankQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppProdmodeUnionbankQueryModel : AlipayObject
    {
        /// <summary>
        /// 银联编号
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }
    }
}
