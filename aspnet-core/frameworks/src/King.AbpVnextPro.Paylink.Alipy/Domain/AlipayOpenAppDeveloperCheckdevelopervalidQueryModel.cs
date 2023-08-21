using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAppDeveloperCheckdevelopervalidQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppDeveloperCheckdevelopervalidQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }
    }
}
