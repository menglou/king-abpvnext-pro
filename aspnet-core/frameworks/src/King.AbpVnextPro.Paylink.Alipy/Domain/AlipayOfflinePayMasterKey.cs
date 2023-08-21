using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOfflinePayMasterKey Data Structure.
    /// </summary>
    public class AlipayOfflinePayMasterKey : AlipayObject
    {
        /// <summary>
        /// 秘钥id
        /// </summary>
        [JsonPropertyName("key_id")]
        public long KeyId { get; set; }

        /// <summary>
        /// 支付宝脱机服务公钥
        /// </summary>
        [JsonPropertyName("public_key")]
        public string PublicKey { get; set; }
    }
}
