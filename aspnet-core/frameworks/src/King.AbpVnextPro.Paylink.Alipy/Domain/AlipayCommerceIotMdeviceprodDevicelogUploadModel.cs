using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodDevicelogUploadModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodDevicelogUploadModel : AlipayObject
    {
        /// <summary>
        /// 行为日志主体
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// 日志模板名称
        /// </summary>
        [JsonPropertyName("template_name")]
        public string TemplateName { get; set; }
    }
}
