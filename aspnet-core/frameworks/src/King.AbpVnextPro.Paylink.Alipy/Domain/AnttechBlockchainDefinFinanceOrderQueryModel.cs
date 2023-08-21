using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinFinanceOrderQueryModel Data Structure.
    /// </summary>
    public class AnttechBlockchainDefinFinanceOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务参数
        /// </summary>
        [JsonPropertyName("encoded_biz_param")]
        public string EncodedBizParam { get; set; }

        /// <summary>
        /// 系统参数
        /// </summary>
        [JsonPropertyName("sys_param")]
        public SystemParam SysParam { get; set; }
    }
}
