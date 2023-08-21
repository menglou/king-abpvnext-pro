using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// CreativeRefuseExtendInfo Data Structure.
    /// </summary>
    public class CreativeRefuseExtendInfo : AlipayObject
    {
        /// <summary>
        /// 创意审核拒绝的附加信息之图片列表
        /// </summary>
        [JsonPropertyName("image_url_list")]
        public List<string> ImageUrlList { get; set; }
    }
}
