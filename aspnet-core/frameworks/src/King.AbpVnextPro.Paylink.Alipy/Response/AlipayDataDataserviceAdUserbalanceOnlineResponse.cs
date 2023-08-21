using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdUserbalanceOnlineResponse.
    /// </summary>
    public class AlipayDataDataserviceAdUserbalanceOnlineResponse : AlipayResponse
    {
        /// <summary>
        /// 操作成功投放账户id列表
        /// </summary>
        [JsonPropertyName("success_user_id_list")]
        public List<long> SuccessUserIdList { get; set; }
    }
}
