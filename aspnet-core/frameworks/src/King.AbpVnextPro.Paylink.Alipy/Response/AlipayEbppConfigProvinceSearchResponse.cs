using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppConfigProvinceSearchResponse.
    /// </summary>
    public class AlipayEbppConfigProvinceSearchResponse : AlipayResponse
    {
        /// <summary>
        /// 接口主要输出参数列表: AreaInfoResult{List{ areaInfo：{province, cityList<String>}} }
        /// </summary>
        [JsonPropertyName("area_info_result")]
        public List<AreaInfo> AreaInfoResult { get; set; }
    }
}
