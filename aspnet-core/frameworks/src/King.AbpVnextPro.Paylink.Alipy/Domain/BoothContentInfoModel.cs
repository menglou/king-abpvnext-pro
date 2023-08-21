using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// BoothContentInfoModel Data Structure.
    /// </summary>
    public class BoothContentInfoModel : AlipayObject
    {
        /// <summary>
        /// 展台名称
        /// </summary>
        [JsonPropertyName("booth")]
        public string Booth { get; set; }

        /// <summary>
        /// 内容信息列表
        /// </summary>
        [JsonPropertyName("content_info_list")]
        public List<ContentInfoModel> ContentInfoList { get; set; }
    }
}
