﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingOrderstatusQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingOrderstatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 如果商户订单号为空，停车场id和车牌号不能为空，商户订单号优先查询
        /// </summary>
        [JsonPropertyName("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 如果商户订单号为空，停车场id和车牌号不能为空，商户订单号优先查询
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 查询订单时间（不传值为当日时间），格式"yyyy-MM-dd “
        /// </summary>
        [JsonPropertyName("sel_time")]
        public string SelTime { get; set; }

        /// <summary>
        /// 车主平台交易号，不能跟停车场编号和车牌号同时为空
        /// </summary>
        [JsonPropertyName("transaction_no")]
        public string TransactionNo { get; set; }
    }
}
