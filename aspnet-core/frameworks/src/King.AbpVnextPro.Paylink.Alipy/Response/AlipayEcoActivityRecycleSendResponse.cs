using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoActivityRecycleSendResponse.
    /// </summary>
    public class AlipayEcoActivityRecycleSendResponse : AlipayResponse
    {
        /// <summary>
        /// 发放的能量总额
        /// </summary>
        [JsonPropertyName("full_energy")]
        public long FullEnergy { get; set; }
    }
}
