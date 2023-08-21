using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniPoiQueryResponse.
    /// </summary>
    public class AlipayOpenMiniPoiQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 可添加地址的最大数量
        /// </summary>
        [JsonPropertyName("max_count")]
        public long MaxCount { get; set; }

        /// <summary>
        /// POI信息列表
        /// </summary>
        [JsonPropertyName("nearby_address_info_list")]
        public List<NearbyAddressInfo> NearbyAddressInfoList { get; set; }

        /// <summary>
        /// 当前已添加地址数量
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
