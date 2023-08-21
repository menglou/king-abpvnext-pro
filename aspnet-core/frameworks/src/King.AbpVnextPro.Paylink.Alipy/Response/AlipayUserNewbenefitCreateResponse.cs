using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserNewbenefitCreateResponse.
    /// </summary>
    public class AlipayUserNewbenefitCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 权益的ID，可以根据此ID对权益进行操作
        /// </summary>
        [JsonPropertyName("benefit_id")]
        public string BenefitId { get; set; }
    }
}
