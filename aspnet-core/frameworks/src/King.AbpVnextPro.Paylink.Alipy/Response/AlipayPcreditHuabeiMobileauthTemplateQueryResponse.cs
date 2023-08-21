using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMobileauthTemplateQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMobileauthTemplateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 模板查询返回JSON信息，参考 PcreditRpcBaseResult<MobileMemberTemplateInfoVO>
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
