using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankCreditSupplychainArSignResponse.
    /// </summary>
    public class MybankCreditSupplychainArSignResponse : AlipayResponse
    {
        /// <summary>
        /// 合同编号
        /// </summary>
        [JsonPropertyName("ar_no")]
        public string ArNo { get; set; }
    }
}
