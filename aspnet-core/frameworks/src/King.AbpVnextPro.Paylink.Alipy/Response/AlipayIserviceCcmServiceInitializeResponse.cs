using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayIserviceCcmServiceInitializeResponse.
    /// </summary>
    public class AlipayIserviceCcmServiceInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// spi在ccm中的唯一标识，与biz_code一一对应
        /// </summary>
        [JsonPropertyName("spi_ids")]
        public List<SpiResult> SpiIds { get; set; }
    }
}
