using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCraftsmanDataWorkCreateResponse.
    /// </summary>
    public class KoubeiCraftsmanDataWorkCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 作品id
        /// </summary>
        [JsonPropertyName("works")]
        public List<CraftsmanWorkOutIdOpenModel> Works { get; set; }
    }
}
