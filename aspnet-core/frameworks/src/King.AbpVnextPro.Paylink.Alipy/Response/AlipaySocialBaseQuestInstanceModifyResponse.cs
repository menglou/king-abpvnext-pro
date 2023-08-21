using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySocialBaseQuestInstanceModifyResponse.
    /// </summary>
    public class AlipaySocialBaseQuestInstanceModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 返回用户添加小目标实例
        /// </summary>
        [JsonPropertyName("instance")]
        public QuestInstanceDO Instance { get; set; }
    }
}
