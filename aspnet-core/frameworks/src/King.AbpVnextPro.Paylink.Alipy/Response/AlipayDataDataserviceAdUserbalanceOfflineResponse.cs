using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdUserbalanceOfflineResponse.
    /// </summary>
    public class AlipayDataDataserviceAdUserbalanceOfflineResponse : AlipayResponse
    {
        /// <summary>
        /// 操作成功投放账户id列表
        /// </summary>
        [JsonPropertyName("success_user_id_list")]
        public List<string> SuccessUserIdList { get; set; }
    }
}
