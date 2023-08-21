using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerbaseinfoBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序基本信息
        /// </summary>
        [JsonPropertyName("base_info_list")]
        public List<MiniAppBaseInfoQueryResponse> BaseInfoList { get; set; }
    }
}
