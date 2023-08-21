using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiRetailKbcodeQueryResponse.
    /// </summary>
    public class KoubeiRetailKbcodeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑码信息列表
        /// </summary>
        [JsonPropertyName("code_info_list")]
        public List<RetailKbcodeQueryVo> CodeInfoList { get; set; }

        /// <summary>
        /// 口碑码总记录数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
