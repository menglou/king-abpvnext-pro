using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayAssetPointVoucherprodBenefittemplateAddResponse.
    /// </summary>
    public class AlipayAssetPointVoucherprodBenefittemplateAddResponse : AlipayResponse
    {
        /// <summary>
        /// 实际追加金额，单元元
        /// </summary>
        [JsonPropertyName("append_amount")]
        public string AppendAmount { get; set; }

        /// <summary>
        /// 结算平台的流水号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }
    }
}
