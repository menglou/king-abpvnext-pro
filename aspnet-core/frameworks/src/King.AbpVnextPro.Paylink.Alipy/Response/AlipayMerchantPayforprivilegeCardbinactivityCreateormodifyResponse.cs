using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeCardbinactivityCreateormodifyResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeCardbinactivityCreateormodifyResponse : AlipayResponse
    {
        /// <summary>
        /// 新增/修改的结果
        /// </summary>
        [JsonPropertyName("card_bin_info")]
        public CardBinActivityInfo CardBinInfo { get; set; }
    }
}
