using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySocialBaseQuestInstanceAddResponse.
    /// </summary>
    public class AlipaySocialBaseQuestInstanceAddResponse : AlipayResponse
    {
        /// <summary>
        /// 小目标实例模型
        /// </summary>
        [JsonPropertyName("instance")]
        public QuestInstanceDO Instance { get; set; }
    }
}
