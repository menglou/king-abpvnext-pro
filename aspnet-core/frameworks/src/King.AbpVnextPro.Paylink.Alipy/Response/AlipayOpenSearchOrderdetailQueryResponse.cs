using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenSearchOrderdetailQueryResponse.
    /// </summary>
    public class AlipayOpenSearchOrderdetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 申请单详情
        /// </summary>
        [JsonPropertyName("data")]
        public SearchOrderDetailData Data { get; set; }
    }
}
