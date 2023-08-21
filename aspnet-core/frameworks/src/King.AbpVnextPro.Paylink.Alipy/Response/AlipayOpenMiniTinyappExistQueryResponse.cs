using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniTinyappExistQueryResponse.
    /// </summary>
    public class AlipayOpenMiniTinyappExistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否是小程序开发者
        /// </summary>
        [JsonPropertyName("exist_mini")]
        public string ExistMini { get; set; }
    }
}
