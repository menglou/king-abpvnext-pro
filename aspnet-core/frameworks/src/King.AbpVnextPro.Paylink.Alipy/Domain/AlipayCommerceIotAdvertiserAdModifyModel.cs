using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdModifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotAdvertiserAdModifyModel : AlipayObject
    {
        /// <summary>
        /// 下线SN列表
        /// </summary>
        [JsonPropertyName("delete_sn_list")]
        public List<string> DeleteSnList { get; set; }

        /// <summary>
        /// 计划id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
