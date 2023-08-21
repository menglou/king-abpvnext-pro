using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayFundJointaccountListQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountListQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 共同账户列表
        /// </summary>
        [JsonPropertyName("account_list")]
        public List<JointAccountDTO> AccountList { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }
    }
}
