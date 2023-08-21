﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringPosParamModifyModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosParamModifyModel : AlipayObject
    {
        /// <summary>
        /// 账单金额位数
        /// </summary>
        [JsonPropertyName("carry_rule")]
        public string CarryRule { get; set; }

        /// <summary>
        /// 就餐模式（ takeMeal：取餐模式（默认）； foodDelivery：送餐模式 ）
        /// </summary>
        [JsonPropertyName("dining_mode")]
        public string DiningMode { get; set; }

        /// <summary>
        /// 是否开通饿了么（false：否；true：是）
        /// </summary>
        [JsonPropertyName("open_ele")]
        public bool OpenEle { get; set; }

        /// <summary>
        /// 异常操作原因（false：否；true：是）
        /// </summary>
        [JsonPropertyName("reason_flag")]
        public bool ReasonFlag { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 是否有桌台（false:否；true:是）
        /// </summary>
        [JsonPropertyName("table_flag")]
        public bool TableFlag { get; set; }

        /// <summary>
        /// 金额尾数规则（  yuan：元；  horn：角；  cent：分（默认）  ）
        /// </summary>
        [JsonPropertyName("tail_number_rule")]
        public string TailNumberRule { get; set; }

        /// <summary>
        /// 外卖是否自动接单（false：否；true：是）
        /// </summary>
        [JsonPropertyName("takeout_auto_receipt")]
        public bool TakeoutAutoReceipt { get; set; }
    }
}
