using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoEduJzPostPublishResponse.
    /// </summary>
    public class AlipayEcoEduJzPostPublishResponse : AlipayResponse
    {
        /// <summary>
        /// 职位编号
        /// </summary>
        [JsonPropertyName("third_id")]
        public string ThirdId { get; set; }
    }
}
