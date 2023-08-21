using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsDataDiseaseQueryResponse.
    /// </summary>
    public class AlipayInsDataDiseaseQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 匹配的疾病
        /// </summary>
        [JsonPropertyName("disease_list")]
        public List<DiseaseDTO> DiseaseList { get; set; }
    }
}
