using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandScodeEledeUnsignModel Data Structure.
    /// </summary>
    public class AntMerchantExpandScodeEledeUnsignModel : AlipayObject
    {
        /// <summary>
        /// 去标请求
        /// </summary>
        [JsonPropertyName("remove_tag_request")]
        public List<RemoveTagRequest> RemoveTagRequest { get; set; }
    }
}
