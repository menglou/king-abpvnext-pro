using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringKdsInfoQueryResponse.
    /// </summary>
    public class KoubeiCateringKdsInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// kds 配置信息列表
        /// </summary>
        [JsonPropertyName("kds_info_model_list")]
        public List<KdsInfoModel> KdsInfoModelList { get; set; }
    }
}
