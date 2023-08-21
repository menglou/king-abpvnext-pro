using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayBossFncUserinvoiceinfoQueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncUserinvoiceinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 开票pid/mid/ou，唯一标识商户信息/集团用户信息的ID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
