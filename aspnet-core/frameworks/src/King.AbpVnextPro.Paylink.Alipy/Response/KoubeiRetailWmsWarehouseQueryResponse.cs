using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiRetailWmsWarehouseQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsWarehouseQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 记录总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 仓库信息
        /// </summary>
        [JsonPropertyName("warehouses")]
        public List<WarehouseVO> Warehouses { get; set; }
    }
}
