using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ListListComplexMockModel Data Structure.
    /// </summary>
    public class ListListComplexMockModel : AlipayObject
    {
        /// <summary>
        /// 复杂对象list
        /// </summary>
        [JsonPropertyName("cm_list")]
        public List<ComplextMockModel> CmList { get; set; }
    }
}
