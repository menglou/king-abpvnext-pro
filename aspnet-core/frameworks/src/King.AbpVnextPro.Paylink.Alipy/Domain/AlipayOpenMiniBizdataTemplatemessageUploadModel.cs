using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenMiniBizdataTemplatemessageUploadModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniBizdataTemplatemessageUploadModel : AlipayObject
    {
        /// <summary>
        /// 服务信息列表，列表大小不超过50
        /// </summary>
        [JsonPropertyName("biz_data_list")]
        public List<UserAppBizDataInfo> BizDataList { get; set; }
    }
}
