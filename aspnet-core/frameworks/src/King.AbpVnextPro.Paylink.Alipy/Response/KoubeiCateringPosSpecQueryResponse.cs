using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringPosSpecQueryResponse.
    /// </summary>
    public class KoubeiCateringPosSpecQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 规格列表
        /// </summary>
        [JsonPropertyName("specs")]
        public List<SpecEntity> Specs { get; set; }
    }
}
