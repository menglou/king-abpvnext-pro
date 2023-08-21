using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeMobileappBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeMobileappBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 移动应用信息列表
        /// </summary>
        [JsonPropertyName("mobile_app_info_list")]
        public List<MobileAppInfo> MobileAppInfoList { get; set; }
    }
}
