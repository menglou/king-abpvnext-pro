using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenDesCreateResponse.
    /// </summary>
    public class AlipayOpenDesCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("ces")]
        public GavintestNewLeveaOne Ces { get; set; }
    }
}
