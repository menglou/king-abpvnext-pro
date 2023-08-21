using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniShopActivityCancelResponse.
    /// </summary>
    public class AlipayOpenMiniShopActivityCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 返回传入的业务处理流水号
        /// </summary>
        [JsonPropertyName("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
