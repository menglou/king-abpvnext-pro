using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntfortuneEquityInstpointTransQueryResponse.
    /// </summary>
    public class AntfortuneEquityInstpointTransQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询到的结果
        /// </summary>
        [JsonPropertyName("trans_info")]
        public List<PointTransInfo> TransInfo { get; set; }
    }
}
