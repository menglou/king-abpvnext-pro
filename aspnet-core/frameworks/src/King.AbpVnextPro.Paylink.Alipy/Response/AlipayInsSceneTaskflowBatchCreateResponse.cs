﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsSceneTaskflowBatchCreateResponse.
    /// </summary>
    public class AlipayInsSceneTaskflowBatchCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 任务流水列表
        /// </summary>
        [JsonPropertyName("task_flow_id_list")]
        public List<string> TaskFlowIdList { get; set; }
    }
}
