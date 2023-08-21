using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandShopPageQueryResponse.
    /// </summary>
    public class AntMerchantExpandShopPageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 门店详情
        /// </summary>
        [JsonPropertyName("shop_infos")]
        public List<ShopQueryOpenApiVO> ShopInfos { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_pages")]
        public long TotalPages { get; set; }
    }
}
