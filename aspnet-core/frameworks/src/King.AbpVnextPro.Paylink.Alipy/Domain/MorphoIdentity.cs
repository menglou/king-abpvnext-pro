using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MorphoIdentity Data Structure.
    /// </summary>
    public class MorphoIdentity : AlipayObject
    {
        /// <summary>
        /// 闪蝶侧用户身份唯一标识
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }
    }
}
