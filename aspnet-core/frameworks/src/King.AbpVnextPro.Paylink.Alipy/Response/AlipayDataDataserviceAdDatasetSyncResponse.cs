using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdDatasetSyncResponse.
    /// </summary>
    public class AlipayDataDataserviceAdDatasetSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 成功同步数据集外部标志
        /// </summary>
        [JsonPropertyName("data_id")]
        public string DataId { get; set; }
    }
}
