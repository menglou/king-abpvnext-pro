using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantGoodsSyncResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantGoodsSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 业务处理成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
