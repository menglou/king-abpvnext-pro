using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiRetailWmsInventoryrecordQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsInventoryrecordQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 库存变更记录
        /// </summary>
        [JsonPropertyName("inventory_record_list")]
        public List<InventoryRecord> InventoryRecordList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 页码大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total_count")]
        public string TotalCount { get; set; }
    }
}
