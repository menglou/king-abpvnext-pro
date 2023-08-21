using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandItemOpenBatchqueryResponse.
    /// </summary>
    public class AntMerchantExpandItemOpenBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品列表。
        /// </summary>
        [JsonPropertyName("item_list")]
        public List<CmItemInfo> ItemList { get; set; }
    }
}
