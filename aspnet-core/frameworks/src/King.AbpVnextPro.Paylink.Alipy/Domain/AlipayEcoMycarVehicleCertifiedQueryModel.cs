﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoMycarVehicleCertifiedQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarVehicleCertifiedQueryModel : AlipayObject
    {
        /// <summary>
        /// 车牌列表
        /// </summary>
        [JsonPropertyName("plate_no_list")]
        public List<string> PlateNoList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
