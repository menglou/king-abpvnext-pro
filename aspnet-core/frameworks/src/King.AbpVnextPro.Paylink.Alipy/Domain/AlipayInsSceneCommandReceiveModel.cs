using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsSceneCommandReceiveModel Data Structure.
    /// </summary>
    public class AlipayInsSceneCommandReceiveModel : AlipayObject
    {
        /// <summary>
        /// 命令对象
        /// </summary>
        [JsonPropertyName("command")]
        public Command Command { get; set; }
    }
}
