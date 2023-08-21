using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsAutoUserCampaignQueryResponse.
    /// </summary>
    public class AlipayInsAutoUserCampaignQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户参与状态。  未参与：WITHOUT_REGISTER  参与：REGISTER
        /// </summary>
        [JsonPropertyName("register_status")]
        public string RegisterStatus { get; set; }
    }
}
