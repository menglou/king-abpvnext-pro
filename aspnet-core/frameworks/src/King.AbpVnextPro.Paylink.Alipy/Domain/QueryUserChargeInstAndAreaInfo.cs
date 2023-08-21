﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// QueryUserChargeInstAndAreaInfo Data Structure.
    /// </summary>
    public class QueryUserChargeInstAndAreaInfo : AlipayObject
    {
        /// <summary>
        /// 出账机构简称
        /// </summary>
        [JsonPropertyName("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 出账机构名称
        /// </summary>
        [JsonPropertyName("charge_inst_name")]
        public string ChargeInstName { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 城市编号
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 缴费次数
        /// </summary>
        [JsonPropertyName("pay_count")]
        public string PayCount { get; set; }

        /// <summary>
        /// 最近一次缴费日期
        /// </summary>
        [JsonPropertyName("pay_date")]
        public string PayDate { get; set; }

        /// <summary>
        /// 子业务类型：   电费:ELECTRIC,水费:WATER,GAS:燃气费    暖气费：HEATING, 有线电视费:CATV
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
