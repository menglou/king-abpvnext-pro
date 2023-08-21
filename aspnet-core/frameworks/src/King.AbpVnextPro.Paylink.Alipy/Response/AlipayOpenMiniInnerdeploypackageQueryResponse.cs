using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerdeploypackageQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerdeploypackageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序部署包模型
        /// </summary>
        [JsonPropertyName("app_deploy_package")]
        public OpenAppDeployPackageVO AppDeployPackage { get; set; }
    }
}
