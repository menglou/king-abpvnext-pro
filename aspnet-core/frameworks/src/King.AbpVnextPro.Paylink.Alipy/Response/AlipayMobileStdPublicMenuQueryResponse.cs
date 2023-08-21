using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMobileStdPublicMenuQueryResponse.
    /// </summary>
    public class AlipayMobileStdPublicMenuQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 所有菜单列表json串
        /// </summary>
        [JsonPropertyName("all_menu_list")]
        public string AllMenuList { get; set; }
    }
}
