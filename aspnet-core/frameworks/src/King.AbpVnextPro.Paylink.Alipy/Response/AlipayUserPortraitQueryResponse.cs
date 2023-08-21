using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserPortraitQueryResponse.
    /// </summary>
    public class AlipayUserPortraitQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 拼团信息列表
        /// </summary>
        [JsonPropertyName("pintuan_user_infos")]
        public List<PintuanUserInfos> PintuanUserInfos { get; set; }
    }
}
