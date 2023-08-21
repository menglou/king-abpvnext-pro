using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// PlateNoCertDto Data Structure.
    /// </summary>
    public class PlateNoCertDto : AlipayObject
    {
        /// <summary>
        /// true，false
        /// </summary>
        [JsonPropertyName("cert_result")]
        public bool CertResult { get; set; }

        /// <summary>
        /// 车牌号码
        /// </summary>
        [JsonPropertyName("plate_no")]
        public string PlateNo { get; set; }
    }
}
