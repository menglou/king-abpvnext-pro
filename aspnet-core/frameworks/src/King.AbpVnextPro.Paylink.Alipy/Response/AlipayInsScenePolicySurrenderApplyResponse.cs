using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsScenePolicySurrenderApplyResponse.
    /// </summary>
    public class AlipayInsScenePolicySurrenderApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 蚂蚁保险平台生成的保单号
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }
    }
}
