using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMerchantMrchsurpActivitysignupCreateResponse.
    /// </summary>
    public class AlipayMerchantMrchsurpActivitysignupCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 报名成功后返回报名记录ID，报名失败无该字段
        /// </summary>
        [JsonPropertyName("signup_record_id")]
        public string SignupRecordId { get; set; }
    }
}
