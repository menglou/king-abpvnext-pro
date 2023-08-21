using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessTicketQueryModel Data Structure.
    /// </summary>
    public class AlipayBossBaseProcessTicketQueryModel : AlipayObject
    {
        /// <summary>
        /// 流程实例Id
        /// </summary>
        [JsonPropertyName("puid")]
        public string Puid { get; set; }
    }
}
