using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMobilePublicMenuQueryResponse.
    /// </summary>
    public class AlipayMobilePublicMenuQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 所有菜单列表json串
        /// </summary>
        [JsonPropertyName("all_menu_list")]
        public string AllMenuList { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonPropertyName("msg")]
        public new string Msg { get; set; }
    }
}
