using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsSceneInsassetprodPetprofilelistQueryModel Data Structure.
    /// </summary>
    public class AlipayInsSceneInsassetprodPetprofilelistQueryModel : AlipayObject
    {
        /// <summary>
        /// 渠道
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }
    }
}
