using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySocialAntfarmProjectinfoQueryResponse.
    /// </summary>
    public class AlipaySocialAntfarmProjectinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 正在进行的项目，含当前正在进行的标的物
        /// </summary>
        [JsonPropertyName("project_list")]
        public List<AntfarmProjectInfo> ProjectList { get; set; }
    }
}
