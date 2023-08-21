using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AuthorizeDetailDTO Data Structure.
    /// </summary>
    public class AuthorizeDetailDTO : AlipayObject
    {
        /// <summary>
        /// 收单主体PID
        /// </summary>
        [JsonPropertyName("authorized_principal_id")]
        public string AuthorizedPrincipalId { get; set; }
    }
}
