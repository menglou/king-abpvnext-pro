using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicUserExpressQueryResponse.
    /// </summary>
    public class AlipayOpenPublicUserExpressQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否为快捷绑卡用户
        /// </summary>
        [JsonPropertyName("express_user")]
        public bool ExpressUser { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
