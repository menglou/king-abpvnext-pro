using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntOcrVehicleplateIdentifyResponse.
    /// </summary>
    public class AntOcrVehicleplateIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 识别结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
