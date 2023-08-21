using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandIotdeviceOnlinedataUploadResponse.
    /// </summary>
    public class AntMerchantExpandIotdeviceOnlinedataUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 商户合作设备在线时间回传结果
        /// </summary>
        [JsonPropertyName("onlinedata_upload_result")]
        public bool OnlinedataUploadResult { get; set; }
    }
}
