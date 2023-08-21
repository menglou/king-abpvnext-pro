using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsSceneSellerActivityQueryResponse.
    /// </summary>
    public class AlipayInsSceneSellerActivityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 关于签约查询结果的告知
        /// </summary>
        [JsonPropertyName("ins_seller_activity")]
        public InsSellerActivity InsSellerActivity { get; set; }
    }
}
