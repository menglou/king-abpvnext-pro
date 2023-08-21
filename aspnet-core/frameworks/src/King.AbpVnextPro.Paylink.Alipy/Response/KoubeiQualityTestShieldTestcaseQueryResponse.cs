using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiQualityTestShieldTestcaseQueryResponse.
    /// </summary>
    public class KoubeiQualityTestShieldTestcaseQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 测试用例列表
        /// </summary>
        [JsonPropertyName("case_list")]
        public List<TestCaseDomain> CaseList { get; set; }

        /// <summary>
        /// 拓展信息
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public string ExtInfos { get; set; }
    }
}
