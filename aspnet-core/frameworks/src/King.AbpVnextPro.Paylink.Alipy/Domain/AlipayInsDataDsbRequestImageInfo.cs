using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsDataDsbRequestImageInfo Data Structure.
    /// </summary>
    public class AlipayInsDataDsbRequestImageInfo : AlipayObject
    {
        /// <summary>
        /// 图像文件名称
        /// </summary>
        [JsonPropertyName("image_name")]
        public string ImageName { get; set; }

        /// <summary>
        /// 图像文件在存储上的路径
        /// </summary>
        [JsonPropertyName("image_path")]
        public string ImagePath { get; set; }
    }
}
