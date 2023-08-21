using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// RemoveTagResponse Data Structure.
    /// </summary>
    public class RemoveTagResponse : AlipayObject
    {
        /// <summary>
        /// 批量去标接口结果列表
        /// </summary>
        [JsonPropertyName("remove_tag_result")]
        public List<RemoveTagResult> RemoveTagResult { get; set; }
    }
}
