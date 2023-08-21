using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserlogoutEffectResponse.
    /// </summary>
    public class KoubeiMerchantKbcloudSubuserlogoutEffectResponse : AlipayResponse
    {
        /// <summary>
        /// 是否登出成功
        /// </summary>
        [JsonPropertyName("flag")]
        public bool Flag { get; set; }
    }
}
