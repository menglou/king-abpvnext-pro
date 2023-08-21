using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppMerchantConfigGetResponse.
    /// </summary>
    public class AlipayEbppMerchantConfigGetResponse : AlipayResponse
    {
        /// <summary>
        /// 商户机构配置信息
        /// </summary>
        [JsonPropertyName("inst_configs")]
        public List<MerchantInstConfig> InstConfigs { get; set; }

        /// <summary>
        /// 商户的用户ID
        /// </summary>
        [JsonPropertyName("merchant_user_id")]
        public string MerchantUserId { get; set; }
    }
}
