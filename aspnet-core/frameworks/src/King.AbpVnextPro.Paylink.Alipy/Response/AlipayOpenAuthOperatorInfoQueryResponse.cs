using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAuthOperatorInfoQueryResponse.
    /// </summary>
    public class AlipayOpenAuthOperatorInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 操作员基础信息
        /// </summary>
        [JsonPropertyName("operator_info")]
        public OperatorBasicInfo OperatorInfo { get; set; }
    }
}
