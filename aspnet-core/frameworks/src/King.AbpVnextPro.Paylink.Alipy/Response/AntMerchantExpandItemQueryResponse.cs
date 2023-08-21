using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandItemQueryResponse.
    /// </summary>
    public class AntMerchantExpandItemQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [JsonPropertyName("item_list")]
        public List<ItemModel> ItemList { get; set; }
    }
}
