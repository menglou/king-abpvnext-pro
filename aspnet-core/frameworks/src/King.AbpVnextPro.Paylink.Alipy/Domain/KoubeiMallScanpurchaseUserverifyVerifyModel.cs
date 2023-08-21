using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMallScanpurchaseUserverifyVerifyModel Data Structure.
    /// </summary>
    public class KoubeiMallScanpurchaseUserverifyVerifyModel : AlipayObject
    {
        /// <summary>
        /// 口碑店铺ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 核销码
        /// </summary>
        [JsonPropertyName("verify_code")]
        public string VerifyCode { get; set; }
    }
}
