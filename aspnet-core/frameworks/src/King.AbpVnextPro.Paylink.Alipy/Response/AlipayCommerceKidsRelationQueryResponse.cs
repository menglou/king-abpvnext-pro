using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceKidsRelationQueryResponse.
    /// </summary>
    public class AlipayCommerceKidsRelationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 孩子信息列表
        /// </summary>
        [JsonPropertyName("relation_list")]
        public List<UserInfoVO> RelationList { get; set; }
    }
}
