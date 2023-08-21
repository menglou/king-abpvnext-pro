using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiRetailWmsDeliverypackageQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsDeliverypackageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 包裹列表
        /// </summary>
        [JsonPropertyName("delivery_package_vo_list")]
        public List<DeliveryPackageVO> DeliveryPackageVoList { get; set; }
    }
}
