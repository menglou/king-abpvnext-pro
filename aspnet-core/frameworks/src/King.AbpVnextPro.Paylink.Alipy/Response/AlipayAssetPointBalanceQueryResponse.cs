using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayAssetPointBalanceQueryResponse.
    /// </summary>
    public class AlipayAssetPointBalanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户的集分宝余额
        /// </summary>
        [JsonPropertyName("point_amount")]
        public long PointAmount { get; set; }
    }
}
