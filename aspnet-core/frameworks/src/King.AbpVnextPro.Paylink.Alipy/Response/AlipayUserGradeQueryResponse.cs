using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserGradeQueryResponse.
    /// </summary>
    public class AlipayUserGradeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户的蚂蚁会员积分余额
        /// </summary>
        [JsonPropertyName("balance")]
        public long Balance { get; set; }

        /// <summary>
        /// 用户的蚂蚁会员等级
        /// </summary>
        [JsonPropertyName("grade")]
        public string Grade { get; set; }
    }
}
