using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceSportsCheerResultConfirmResponse.
    /// </summary>
    public class AlipayCommerceSportsCheerResultConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 用户流水号
        /// </summary>
        [JsonPropertyName("game_serial_number")]
        public string GameSerialNumber { get; set; }
    }
}
