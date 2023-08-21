using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodUserCertifyModel Data Structure.
    /// </summary>
    public class AlipayInsAutoAutoinsprodUserCertifyModel : AlipayObject
    {
        /// <summary>
        /// 代理人姓名
        /// </summary>
        [JsonPropertyName("agent_id_card_name")]
        public string AgentIdCardName { get; set; }

        /// <summary>
        /// 代理人身份证号
        /// </summary>
        [JsonPropertyName("agent_id_card_no")]
        public string AgentIdCardNo { get; set; }

        /// <summary>
        /// 代理人用户唯一标识
        /// </summary>
        [JsonPropertyName("agent_user_id")]
        public string AgentUserId { get; set; }
    }
}
