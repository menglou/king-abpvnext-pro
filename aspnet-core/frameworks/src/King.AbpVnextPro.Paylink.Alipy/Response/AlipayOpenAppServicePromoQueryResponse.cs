using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppServicePromoQueryResponse.
    /// </summary>
    public class AlipayOpenAppServicePromoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 编辑中版本的服务场景素材详情
        /// </summary>
        [JsonPropertyName("editing_service_promo")]
        public ServicePromoBaseVO EditingServicePromo { get; set; }

        /// <summary>
        /// 生效版本的服务场景素材详情
        /// </summary>
        [JsonPropertyName("valid_service_promo")]
        public ServicePromoBaseVO ValidServicePromo { get; set; }
    }
}
