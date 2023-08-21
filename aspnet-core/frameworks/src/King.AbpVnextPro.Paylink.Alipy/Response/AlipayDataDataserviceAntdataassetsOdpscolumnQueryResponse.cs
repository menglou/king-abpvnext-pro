using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsOdpscolumnQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAntdataassetsOdpscolumnQueryResponse : AlipayResponse
    {
        /// <summary>
        /// ODPS的列信息，包含ODPS字段名和字段类型
        /// </summary>
        [JsonPropertyName("odps_columns")]
        public List<AntdataassetsOdpsColumn> OdpsColumns { get; set; }
    }
}
