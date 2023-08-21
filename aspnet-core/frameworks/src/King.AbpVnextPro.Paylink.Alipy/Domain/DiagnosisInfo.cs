﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// DiagnosisInfo Data Structure.
    /// </summary>
    public class DiagnosisInfo : AlipayObject
    {
        /// <summary>
        /// 推荐的决策码，业务方可以根据这个码来做具体的事情
        /// </summary>
        [JsonPropertyName("decision_code")]
        public string DecisionCode { get; set; }

        /// <summary>
        /// 对决策信息的中文描述，方便业务方能更好感知问题解决方案
        /// </summary>
        [JsonPropertyName("decision_desc")]
        public string DecisionDesc { get; set; }

        /// <summary>
        /// 系统异常
        /// </summary>
        [JsonPropertyName("orgin_error_code")]
        public string OrginErrorCode { get; set; }

        /// <summary>
        /// 错误原因的code类型，外围可以用这个类型，知道是什么原因
        /// </summary>
        [JsonPropertyName("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 对于错误原因的具体中文描述
        /// </summary>
        [JsonPropertyName("reason_desc")]
        public string ReasonDesc { get; set; }

        /// <summary>
        /// 具体问题的时间
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; }
    }
}
