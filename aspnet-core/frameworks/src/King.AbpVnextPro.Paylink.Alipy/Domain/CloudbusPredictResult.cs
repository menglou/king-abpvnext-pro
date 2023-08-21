﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// CloudbusPredictResult Data Structure.
    /// </summary>
    public class CloudbusPredictResult : AlipayObject
    {
        /// <summary>
        /// 执行任务状态描述
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 进度50%
        /// </summary>
        [JsonPropertyName("progress")]
        public long Progress { get; set; }

        /// <summary>
        /// 预测线路
        /// </summary>
        [JsonPropertyName("routes")]
        public List<CloudbusRouteRItem> Routes { get; set; }

        /// <summary>
        /// 影响下降线路
        /// </summary>
        [JsonPropertyName("routes_decreased")]
        public List<CloudbusRouteRItem> RoutesDecreased { get; set; }

        /// <summary>
        /// 客流预测影响下降线路
        /// </summary>
        [JsonPropertyName("routes_increased")]
        public List<CloudbusRouteRItem> RoutesIncreased { get; set; }

        /// <summary>
        /// 任务状态：0：准备 1：运行中 2：成功 3： 失败： 4：终止 5： 其他
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }
    }
}
