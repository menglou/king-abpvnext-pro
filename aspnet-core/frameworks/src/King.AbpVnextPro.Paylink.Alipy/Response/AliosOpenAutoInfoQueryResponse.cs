﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AliosOpenAutoInfoQueryResponse.
    /// </summary>
    public class AliosOpenAutoInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 发动机号
        /// </summary>
        [JsonPropertyName("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 用户激活时间
        /// </summary>
        [JsonPropertyName("user_activation_time")]
        public string UserActivationTime { get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        [JsonPropertyName("vehicle_type")]
        public string VehicleType { get; set; }

        /// <summary>
        /// 车辆识别号码
        /// </summary>
        [JsonPropertyName("vin")]
        public string Vin { get; set; }
    }
}
