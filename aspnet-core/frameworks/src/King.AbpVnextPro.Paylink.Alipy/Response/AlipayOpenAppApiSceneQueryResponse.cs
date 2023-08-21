using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppApiSceneQueryResponse.
    /// </summary>
    public class AlipayOpenAppApiSceneQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 接口信息字段应用场景
        /// </summary>
        [JsonPropertyName("auth_field_scene")]
        public List<AuthFieldSceneDTO> AuthFieldScene { get; set; }
    }
}
