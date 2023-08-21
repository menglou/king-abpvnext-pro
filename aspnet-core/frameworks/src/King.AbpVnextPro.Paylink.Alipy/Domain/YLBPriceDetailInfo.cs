﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// YLBPriceDetailInfo Data Structure.
    /// </summary>
    public class YLBPriceDetailInfo : AlipayObject
    {
        /// <summary>
        /// 余利宝行情日期，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("price_date")]
        public string PriceDate { get; set; }

        /// <summary>
        /// 七日年化收益率（%），精确到小数点后4位
        /// </summary>
        [JsonPropertyName("sevendays_yeild_rate")]
        public string SevendaysYeildRate { get; set; }

        /// <summary>
        /// 万份收益金额，单位为元
        /// </summary>
        [JsonPropertyName("tenthousand_income")]
        public string TenthousandIncome { get; set; }
    }
}
