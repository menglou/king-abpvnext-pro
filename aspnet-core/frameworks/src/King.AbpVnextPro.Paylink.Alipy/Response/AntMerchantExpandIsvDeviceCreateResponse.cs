using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandIsvDeviceCreateResponse.
    /// </summary>
    public class AntMerchantExpandIsvDeviceCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 机具申请物料订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
