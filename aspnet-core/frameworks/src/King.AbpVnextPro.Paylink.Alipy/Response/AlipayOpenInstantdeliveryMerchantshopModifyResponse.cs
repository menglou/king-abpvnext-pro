using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantshopModifyResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryMerchantshopModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 门店创建返回的结果
        /// </summary>
        [JsonPropertyName("logistics_shop_status")]
        public List<LogisticsShopStatusDTO> LogisticsShopStatus { get; set; }
    }
}
