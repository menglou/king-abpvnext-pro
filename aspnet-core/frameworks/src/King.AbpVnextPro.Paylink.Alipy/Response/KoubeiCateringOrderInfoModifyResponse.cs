using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringOrderInfoModifyResponse.
    /// </summary>
    public class KoubeiCateringOrderInfoModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 是否需要重试,true-需要重试 ,false-不需要重试
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
