using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceDeployorderDetailQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceDeployorderDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 部署单列表
        /// </summary>
        [JsonPropertyName("deploy_order_list")]
        public List<DxDeployOrderInfo> DeployOrderList { get; set; }
    }
}
