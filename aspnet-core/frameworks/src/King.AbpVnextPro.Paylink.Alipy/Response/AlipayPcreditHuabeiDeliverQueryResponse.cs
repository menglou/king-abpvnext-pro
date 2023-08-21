using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiDeliverQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiDeliverQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 配置ID
        /// </summary>
        [JsonPropertyName("config_id")]
        public string ConfigId { get; set; }
    }
}
