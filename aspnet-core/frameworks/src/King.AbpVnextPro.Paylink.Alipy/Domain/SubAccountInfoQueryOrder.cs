using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// SubAccountInfoQueryOrder Data Structure.
    /// </summary>
    public class SubAccountInfoQueryOrder : AlipayObject
    {
        /// <summary>
        /// 开户申请时获取到的受理单号
        /// </summary>
        [JsonPropertyName("apply_no")]
        public string ApplyNo { get; set; }
    }
}
