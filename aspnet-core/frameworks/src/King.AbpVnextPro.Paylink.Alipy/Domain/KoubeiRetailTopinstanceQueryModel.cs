using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiRetailTopinstanceQueryModel Data Structure.
    /// </summary>
    public class KoubeiRetailTopinstanceQueryModel : AlipayObject
    {
        /// <summary>
        /// 券或者电子DM单（VOUCHER、DM）
        /// </summary>
        [JsonPropertyName("instance_type")]
        public string InstanceType { get; set; }
    }
}
