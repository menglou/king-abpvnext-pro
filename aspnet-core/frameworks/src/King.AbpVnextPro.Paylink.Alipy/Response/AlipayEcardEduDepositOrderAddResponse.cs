using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcardEduDepositOrderAddResponse.
    /// </summary>
    public class AlipayEcardEduDepositOrderAddResponse : AlipayResponse
    {
        /// <summary>
        /// 支付申请流水号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
