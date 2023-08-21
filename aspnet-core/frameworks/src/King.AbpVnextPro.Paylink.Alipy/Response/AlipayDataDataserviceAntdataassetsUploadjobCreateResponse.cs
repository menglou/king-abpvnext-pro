﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsUploadjobCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceAntdataassetsUploadjobCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建上云任务之后生成的任务ID
        /// </summary>
        [JsonPropertyName("uca_dataset_id")]
        public long UcaDatasetId { get; set; }
    }
}
