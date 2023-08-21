using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppJfexportInputfieldQueryResponse.
    /// </summary>
    public class AlipayEbppJfexportInputfieldQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 输出的输入域列表
        /// </summary>
        [JsonPropertyName("input_fields")]
        public List<JFExportInputFieldModel> InputFields { get; set; }
    }
}
