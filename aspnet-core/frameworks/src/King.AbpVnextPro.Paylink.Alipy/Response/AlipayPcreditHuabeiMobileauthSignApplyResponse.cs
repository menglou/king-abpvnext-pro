using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMobileauthSignApplyResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMobileauthSignApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 模板查询返回JSON信息，参考 PcreditAuthSignApplyResult
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
