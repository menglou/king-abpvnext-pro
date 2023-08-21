using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayFinanceQuotationStocktoolsFreeuserExchangeResponse.
    /// </summary>
    public class AlipayFinanceQuotationStocktoolsFreeuserExchangeResponse : AlipayResponse
    {
        /// <summary>
        /// 领取成功/失败，此处为false时，或者接口本身报错时，均意味着失败
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
