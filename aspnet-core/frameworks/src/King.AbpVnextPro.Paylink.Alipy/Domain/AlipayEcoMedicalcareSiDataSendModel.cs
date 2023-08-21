﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoMedicalcareSiDataSendModel Data Structure.
    /// </summary>
    public class AlipayEcoMedicalcareSiDataSendModel : AlipayObject
    {
        /// <summary>
        /// 场景标识  si_payment_income 缴费到账  si_medical_consume_detail 医保消费  si_medical_consume_month 医保月账单
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 城市编码，国标码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonPropertyName("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 根据场景不同的模型数据, json 数组格式
        /// </summary>
        [JsonPropertyName("si_data")]
        public List<SiData> SiData { get; set; }

        /// <summary>
        /// 返佣合作伙伴id
        /// </summary>
        [JsonPropertyName("sys_service_provider_id")]
        public string SysServiceProviderId { get; set; }

        /// <summary>
        /// 通知时间，为空为当前时间立即发送  格式：yyyyMMddHHmms
        /// </summary>
        [JsonPropertyName("target_notify_time")]
        public string TargetNotifyTime { get; set; }
    }
}
