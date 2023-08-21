using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataIotdataUserBusinessQueryResponse.
    /// </summary>
    public class AlipayDataIotdataUserBusinessQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户管理的业务列表
        /// </summary>
        [JsonPropertyName("data")]
        public List<UserBusiness> Data { get; set; }
    }
}
