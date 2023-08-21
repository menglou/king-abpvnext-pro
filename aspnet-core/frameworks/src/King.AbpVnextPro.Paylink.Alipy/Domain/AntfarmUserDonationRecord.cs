using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntfarmUserDonationRecord Data Structure.
    /// </summary>
    public class AntfarmUserDonationRecord : AlipayObject
    {
        /// <summary>
        /// 单次捐爱心时间
        /// </summary>
        [JsonPropertyName("charity_time")]
        public string CharityTime { get; set; }

        /// <summary>
        /// 单次捐爱心数量
        /// </summary>
        [JsonPropertyName("donation_amount")]
        public long DonationAmount { get; set; }
    }
}
