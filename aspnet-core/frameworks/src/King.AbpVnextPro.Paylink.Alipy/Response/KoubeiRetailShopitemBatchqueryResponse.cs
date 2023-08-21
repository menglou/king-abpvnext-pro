using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiRetailShopitemBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailShopitemBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 店铺商品集合
        /// </summary>
        [JsonPropertyName("shopitemlist")]
        public List<ExtShopItem> Shopitemlist { get; set; }
    }
}
