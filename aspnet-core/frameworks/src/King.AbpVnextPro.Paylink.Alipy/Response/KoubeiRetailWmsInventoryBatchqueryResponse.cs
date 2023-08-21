using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiRetailWmsInventoryBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailWmsInventoryBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 库存列表
        /// </summary>
        [JsonPropertyName("inventory_list")]
        public List<Inventory> InventoryList { get; set; }
    }
}
