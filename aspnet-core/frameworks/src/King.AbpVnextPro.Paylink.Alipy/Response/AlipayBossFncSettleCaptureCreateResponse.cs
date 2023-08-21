using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossFncSettleCaptureCreateResponse.
    /// </summary>
    public class AlipayBossFncSettleCaptureCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 请款创建数据对象
        /// </summary>
        [JsonPropertyName("result_set")]
        public List<CaptureCreateDTO> ResultSet { get; set; }
    }
}
