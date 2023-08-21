using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPointBalanceGetResponse.
    /// </summary>
    public class AlipayPointBalanceGetResponse : AlipayResponse
    {
        /// <summary>
        /// 用户的集分宝余额
        /// </summary>
        [JsonPropertyName("point_amount")]
        public long PointAmount { get; set; }
    }
}
